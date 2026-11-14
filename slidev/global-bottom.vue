<template>
  <div class="ud-brand-footer">
    <span class="ud-brand-footer-left">UD01 · Introducción a la Programación Software</span>
    <span class="ud-brand-footer-right">Programación · 1DAW · IES Luis Vives · joseluisgs.dev</span>
  </div>
</template>

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
