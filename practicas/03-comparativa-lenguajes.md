# Práctica 3: Comparativa de Lenguajes - Java, C#, Python y TypeScript

**Objetivo:** Comprender y analizar en profundidad el proceso de compilación y ejecución de cuatro lenguajes de programación modernos, identificando las similitudes y diferencias clave.

---

**Descripción:**

En esta actividad, realizarás una investigación comparativa sobre cómo un programa escrito en cada uno de estos cuatro lenguajes se transforma desde el código fuente que escribes hasta convertirse en una aplicación funcional. Deberás explorar los componentes clave como compiladores, código intermedio, máquinas virtuales y transpiladores.

**Tareas a Realizar:**

0. **Hola Mundo en los 4 lenguajes:** Escribe y ejecuta un "Hola Mundo" en cada lenguaje para ver las diferencias de sintaxis:

```java
// Java
public class HolaMundo {
    public static void main(String[] args) {
        System.out.println("Hola Mundo");
    }
}
```

```csharp
// C# (con Top-Level Statements)
Console.WriteLine("Hola Mundo");
```

```python
# Python
print("Hola Mundo")
```

```typescript
// TypeScript (se transpila a JavaScript)
console.log("Hola Mundo");
```

1. **Del Código Fuente al Ejecutable:**
   - Investiga y crea un diagrama de flujo o un esquema detallado que ilustre, paso a paso, el proceso completo para cada lenguaje:
     - **Java:** Desde el archivo `.java` hasta la ejecución por la JVM. Identifica el **Bytecode**.
     - **C#:** Desde el archivo `.cs` hasta su ejecución por la CLR. Identifica el **CIL (Common Intermediate Language)**.
     - **Python:** Desde el archivo `.py` hasta su ejecución. Identifica el bytecode `.pyc` y el rol del intérprete.
     - **TypeScript:** Desde el archivo `.ts` hasta su ejecución. Identifica el proceso de **transpilación** a JavaScript.
   - Describe brevemente la función de cada elemento en tus diagramas (compilador `javac`, Roslyn, `tsc`, JIT compiler, CLR, JVM, etc.).

2. **Análisis del Rendimiento en el Primer Arranque:**
   - Investiga el concepto de **Compilación Just-In-Time (JIT)**.
   - Explica razonadamente por qué una aplicación desarrollada en C# o Java puede ser ligeramente más lenta la *primera vez* que se ejecuta en comparación con ejecuciones posteriores. Relaciona tu explicación directamente con el proceso JIT.
   - ¿Python y TypeScript también tienen JIT? Justifica tu respuesta.

3. **La Magia de la Multiplataforma:**
   - Explica cómo el diseño de la **JVM** (Java), la **CLR** (.NET/C#) y el **intérprete de Python** son los responsables de que estos lenguajes sean considerados multiplataforma.
   - TypeScript es transpilado a JavaScript, que se ejecuta en cualquier navegador. ¿Es esto multiplataforma? Justifica tu respuesta.
   - ¿Qué significa la famosa frase de Java: *"Write Once, Run Anywhere"*? ¿Se puede aplicar a C#, Python y TypeScript?

4. **Tabla Comparativa Final:**

| Característica | Java | C# | Python | TypeScript |
|----------------|------|-----|--------|------------|
| **Nivel de abstracción** | | | | |
| **Mecanismo de traducción** | | | | |
| **Tipado** | | | | |
| **Paradigma principal** | | | | |
| **Compilador/Intérprete** | | | | |
| **Máquina Virtual** | | | | |
| **Código intermedio** | | | | |
| **Multiplataforma** | | | | |
| **Rendimiento** | | | | |
| **Casos de uso típicos** | | | | |

**Formato de entrega:** Informe en formato digital (PDF o Markdown) que incluya:
- Los diagramas de flujo o esquemas solicitados para los 4 lenguajes.
- Las respuestas desarrolladas para cada una de las preguntas de análisis.
- La tabla comparativa completada.
- Una conclusión final donde resumas las ventajas y desventajas de cada lenguaje y cuándo elegir uno u otro.
- Las fuentes y bibliografía consultadas.
