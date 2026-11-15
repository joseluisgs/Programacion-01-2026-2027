import type { MermaidConfig } from 'mermaid'

/**
 * Configuración de Mermaid para la presentación de la UD.
 *
 * `useMaxWidth: true` es la clave: hace que el SVG ocupe el 100% del hueco
 * que le toca en la slide. Sin esto, Mermaid le pone al SVG un ancho fijo
 * (el del diagrama) y el diagrama se sale por la derecha de la transparencia.
 */
export default (): MermaidConfig => ({
  theme: 'default',
  startOnLoad: false,
  securityLevel: 'loose',
  flowchart: {
    useMaxWidth: true,
    htmlLabels: true,
    curve: 'basis',
    // Compacto: los diagramas ocupan menos alto y no llegan al pie
    nodeSpacing: 25,
    rankSpacing: 35,
    padding: 4,
  },
  sequence: {
    useMaxWidth: true,
  },
  er: {
    useMaxWidth: true,
  },
  gantt: {
    useMaxWidth: true,
  },
  journey: {
    useMaxWidth: true,
  },
  pie: {
    useMaxWidth: true,
  },
  themeVariables: {
    // Legible en pantalla y en PDF: 15px se veía diminuto en los diagramas
    // pequeños (bug: "nodos con texto de 8px")
    fontSize: '19px',
    fontFamily: "'Ubuntu', 'Segoe UI', system-ui, sans-serif",
  },
})
