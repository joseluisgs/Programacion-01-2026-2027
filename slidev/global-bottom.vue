<template>
  <div class="ud-brand-footer">
    <span class="ud-brand-footer-left">UD01 · Introducción a la Programación Software</span>
    <span class="ud-brand-footer-right">Programación · 1DAW · IES Luis Vives · joseluisgs.dev</span>
  </div>
</template>

<script setup lang="ts">
import { onMounted } from 'vue';

/* ============================================================
   Ajuste de Mermaid: el SVG vive en un shadowRoot, así que el CSS
   externo NO llega a él y el host lo corta con max-height + overflow
   (bug: "diagrama recortado por abajo, nodo a medias").
   Solución: cuando el SVG supera el alto del host, reducimos SU ANCHO
   proporcionalmente; como lleva viewBox, el alto baja solo y el
   diagrama queda COMPLETO (sin recorte) y centrado.
   Nunca se agranda: solo se estrecha.
   ============================================================ */
const RESERVA_ALTO = 350; // respaldo si el host no tiene max-height

function ajustarMermaid(host: Element): void {
  const raiz = (host as Element & { shadowRoot: ShadowRoot | null }).shadowRoot;
  const svg = raiz?.querySelector('svg');
  if (!svg) return;
  // El SVG sale con display:inline (defecto) y la línea de texto le añade
  // ~6px de espacio bajo la línea de base → el host se pasa y se corta.
  // En bloque desaparece ese gap.
  if (svg.style.display !== 'block') svg.style.display = 'block';
  const alto = svg.clientHeight;
  if (!alto) return; // aún no se ha pintado
  const maxCss = parseFloat(getComputedStyle(host).maxHeight) || RESERVA_ALTO;
  // El host es hijo de un flex: el contenedor lo ENCOGE cuando no cabe en el
  // hueco que queda, así que el tope real es su alto ACTUAL. Si limitamos a
  // max-height (350) y el host solo tiene 327, el SVG se pasa y se corta.
  const tope = Math.min(maxCss, host.clientHeight || maxCss);
  if (alto <= tope + 1) return; // ya cabe: no tocar (nunca agrandar)
  svg.style.maxWidth = Math.floor((svg.clientWidth * tope) / alto) + 'px';
}

function barrerMermaid(): void {
  document.querySelectorAll('.mermaid').forEach((host) => {
    ajustarMermaid(host);
    const raiz = (host as Element & { shadowRoot: ShadowRoot | null }).shadowRoot;
    if (raiz && !host.hasAttribute('data-ud-obs')) {
      host.setAttribute('data-ud-obs', '1');
      // El SVG se pinta de forma asíncrona: observamos su shadowRoot.
      // Observamos también el atributo style: al estrechar el SVG vuelve a
      // correr el ajuste (converge: solo se estrecha, nunca se agranda).
      new MutationObserver(() => ajustarMermaid(host)).observe(raiz, {
        childList: true,
        subtree: true,
        attributes: true,
        attributeFilter: ['style'],
      });
    }
  });
}

onMounted(() => {
  barrerMermaid();
  // Mermaid puede tardar en renderizar tras montar la slide
  setTimeout(barrerMermaid, 250);
  setTimeout(barrerMermaid, 800);
});
</script>

<style scoped>
.ud-brand-footer {
  position: absolute;
  left: 0;
  right: 0;
  bottom: 0;
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 0.35em 1.5em;
  font-size: 0.6em;
  letter-spacing: 0.02em;
  color: var(--ud-text-subtle);
  border-top: 1px solid var(--ud-divider);
  background: transparent;
  pointer-events: none;
  z-index: 20;
}
</style>
