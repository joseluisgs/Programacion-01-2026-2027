- [11. Resumen y Conclusiones](#11-resumen-y-conclusiones)
  - [11.1. Mapa Conceptual de la Unidad](#111-mapa-conceptual-de-la-unidad)
  - [11.2. Conceptos Clave](#112-conceptos-clave)
    - [Fundamentos de la Programación](#fundamentos-de-la-programación)
    - [Algoritmos](#algoritmos)
    - [Paradigmas de Programación](#paradigmas-de-programación)
    - [Lenguajes de Programación](#lenguajes-de-programación)
    - [Entorno .NET](#entorno-net)
    - [Estructura de un Programa](#estructura-de-un-programa)
    - [Tipos de Datos](#tipos-de-datos)
    - [Variables, Constantes y Literales](#variables-constantes-y-literales)
    - [Operadores y Expresiones](#operadores-y-expresiones)
    - [Conversiones de Tipo](#conversiones-de-tipo)
    - [Entrada y Salida](#entrada-y-salida)
    - [Comentarios y Documentación](#comentarios-y-documentación)
  - [11.3. Herramientas y Perfiles](#113-herramientas-y-perfiles)
    - [SDK y CLI](#sdk-y-cli)
    - [NuGet](#nuget)
    - [IDE](#ide)
  - [11.4. Errores Comunes a Evitar](#114-errores-comunes-a-evitar)
  - [11.5. Checklist de Supervivencia](#115-checklist-de-supervivencia)


# 11. Resumen y Conclusiones

> 💡 **Punto de partida:** Hemos recorrido todo el camino desde qué es programar hasta escribir nuestro primer programa en C#. Este resumen consolida todo lo aprendido.

Hemos visto la teoría completa de Introducción a la Programación. Este punto consolida todos los conceptos en una sola mirada.

**Objetivos de aprendizaje:**

- Repasar los conceptos fundamentales de la unidad
- Consolidar el vocabulario técnico
- Tener una referencia rápida de todos los temas

## 11.1. Mapa Conceptual de la Unidad

```mermaid
graph TD
    UD01[UD01: Introduccion a la Programacion] --> FUND[Fundamentos]
    UD01 --> ALG[Algoritmos]
    UD01 --> PAR[Paradigmas]
    UD01 --> LENG[Lenguajes]
    UD01 --> ENT[Entorno .NET]
    UD01 --> EST[Estructura del Programa]
    UD01 --> TD[Tipos de Datos]
    UD01 --> VAR[Variables y Constantes]
    UD01 --> OP[Operadores]
    UD01 --> CONV[Conversiones]
    UD01 --> IOS[Entrada y Salida]
    UD01 --> COM[Comentarios]

    FUND --> F1[Que es programar]
    FUND --> F2[Algoritmo vs Programa]

    ALG --> A1[6 Caracteristicas]
    ALG --> A2[Representacion: Diagramas, Pseudocodigo]

    PAR --> P1[Imperativo]
    PAR --> P2[Estructurado]
    PAR --> P3[Modular]
    PAR --> P4[POO]
    PAR --> P5[Funcional]
    PAR --> P6[Declarativo]
    PAR --> P7[Eventos]

    LENG --> L1[Nivel: Bajo, Medio, Alto]
    LENG --> L2[Traduccion: Compilado, Interpretado, Mixto]
    LENG --> L3[Tipado: Estatico/Dinamico, Fuerte/Debil]

    ENT --> E1[SDK y CLI]
    ENT --> E2[NuGet]
    ENT --> E3[IDE: Rider, VS Code]

    EST --> ES1[Top-Level Statements]
    EST --> ES2[Namespaces]
    EST --> ES3[.slnx vs .csproj]

    TD --> T1[Enteros: sbyte, short, int, long]
    TD --> T2[Decimales: float, double, decimal]
    TD --> T3[Texto: char, string]
    TD --> T4[Booleano: bool]

    VAR --> V1[Variables: camelCase]
    VAR --> V2[Constantes: const, PascalCase]
    VAR --> V3[Literales]
    VAR --> V4[Enumeraciones: enum]

    OP --> O1[Aritmeticos]
    OP --> O2[Relacionales]
    OP --> O3[Logicos]
    OP --> O4[Asignacion]
    OP --> O5[Ternario ?:]
    OP --> O6[Coalescencia ??]

    CONV --> C1[Implicita: automatica, segura]
    CONV --> C2[Explicita: casting, peligrosa]
    CONV --> C3[Parse y TryParse]

    IOS --> IO1[WriteLine, Write]
    IOS --> IO2[ReadLine]
    IOS --> IO3[Interpolacion $""]
    IOS --> IO4[Concatenacion +]

    COM --> CO1[// una linea]
    COM --> CO2[/* varias lineas]
    COM --> CO3[/// documentacion XML]
```

## 11.2. Conceptos Clave

### Fundamentos de la Programación
- **Programar:** Escribir instrucciones que el ordenador pueda ejecutar para resolver un problema
- **Algoritmo:** Plan ordenado de pasos para resolver un problema, independiente del lenguaje
- **Programa:** Implementación de un algoritmo en un lenguaje de programación concreto
- **Algoritmo vs Programa:** El algoritmo es el plano, el programa es la casa construida

### Algoritmos
- **Finito:** Termina en algún momento (no es un bucle infinito)
- **Definido:** Cada paso está claramente definido (no hay ambigüedad)
- **Preciso:** Instrucciones exactas (no "más o menos")
- **Entrada:** Tiene datos de entrada (parámetros)
- **Salida:** Produce un resultado
- **Efectividad:** Cada paso es realizables
- **Representación:** Diagramas de flujo, pseudocódigo, lenguaje natural

### Paradigmas de Programación
- **Imperativo:** Paso a paso, cómo hacer las cosas (`for`, `while`)
- **Estructurado:** Organizado con `if`, `switch`, `for`, `while` (sin `goto`)
- **Modular:** Dividido en funciones reutilizables
- **POO:** Objetos con atributos y métodos (los 4 pilares: encapsulamiento, herencia, polimorfismo, abstracción)
- **Funcional:** Funciones puras, sin estado mutable (LINQ en C#)
- **Declarativo:** Se dice qué quiero, no cómo hacerlo (SQL, LINQ)
- **Eventos:** El código responde a acciones del usuario (`Click +=`)
- **C# es multiparadigma:** Combina varios paradigmas

### Lenguajes de Programación
- **Por nivel:** Bajo (máquina, ensamblador), Medio (C), Alto (C#, Python, Java)
- **Por traducción:** Compilados (C++), Interpretados (Python), Mixtos (C# → IL → CLR)
- **Por tipado:** Estático (C#) vs Dinámico (JavaScript), Fuerte (C#) vs Débil (JavaScript)
- **Elementos:** Léxico (símbolos), Sintaxis (reglas), Semántica (significado)

### Entorno .NET
- **SDK:** Software Development Kit (instala compilador, runtime, bibliotecas)
- **CLI:** Command Line Interface (`dotnet new`, `dotnet build`, `dotnet run`)
- **NuGet:** Gestor de paquetes (librerías externas)
- **IDE:** Integrated Development Environment (Rider recomendado)
- **.slnx:** Solución (agrupa varios proyectos)
- **.csproj:** Proyecto (configura uno: framework, paquetes, opciones)

### Estructura de un Programa
- **Top-Level Statements:** Código directo sin `class` ni `Main` (C# 9+)
- **Namespaces:** Agrupan código, evitan conflictos de nombres
- **using static:** Permite usar miembros estáticos sin nombre de clase
- **Sentencia:** Instrucción que termina en `;`
- **Expresión:** Código que produce un valor
- **Método:** Bloque de código reutilizable

### Tipos de Datos
- **Enteros con signo:** `sbyte` (1B), `short` (2B), `int` (4B), `long` (8B)
- **Enteros sin signo:** `byte`, `ushort`, `uint`, `ulong`
- **Decimales:** `float` (7 cifras), `double` (15-16 cifras), `decimal` (28-29 cifras)
- **Texto:** `char` (1 carácter), `string` (texto arbitrario)
- **Booleano:** `bool` (`true` o `false`)
- **`var`:** Inferencia de tipo (el compilador deduce el tipo, no lo cambia después)

### Variables, Constantes y Literales
- **Variable:** Contenedor que puede cambiar. Se declara con tipo + nombre. `camelCase`
- **Constante:** Contenedor que NO puede cambiar. Se declara con `const`. `PascalCase`
- **Literal:** Valor fijo en el código (`42`, `"Hola"`, `true`)
- **Enum:** Conjunto de valores con nombre (`enum DiaSemana`)
- **Scope:** Dónde es visible la variable
- **Lifetime:** Cuánto tiempo vive (mientras se ejecuta su bloque)
- **Código autodocumentado:** Nombres descriptivos que se entienden sin comentarios

### Operadores y Expresiones
- **Aritméticos:** `+`, `-`, `*`, `/`, `%` (módulo)
- **Relacionales:** `==`, `!=`, `<`, `>`, `<=`, `>=`
- **Lógicos:** `&&` (Y), `||` (O), `!` (NO)
- **Asignación:** `=`, `+=`, `-=`, `*=`, `/=`, `%=`
- **Ternario:** `condición ? valorSiTrue : valorSiFalse`
- **Coalescencia:** `valor ?? valorPorDefecto` (si es null, usa el defecto)
- **Precedencia:** Paréntesis `()` antes que todo

### Conversiones de Tipo
- **Implícita:** Automática y segura (`int` → `double`)
- **Explícita (casting):** Manual y peligrosa (`double` → `int`, pierde decimales)
- **Parse:** Convierte string a tipo. Salta excepción si falla
- **TryParse:** Convierte string a tipo. Devuelve `true/false` (el seguro)
- **Convert:** Convierte entre tipos básicos

### Entrada y Salida
- **`Console.WriteLine()`:** Escribe texto y salta de línea
- **`Console.Write()`:** Escribe texto sin salto
- **`Console.ReadLine()`:** Lee una línea del teclado (devuelve `string`)
- **Interpolación:** `$"Tengo {edad} años"` (sustituye variables en strings)
- **Concatenación:** `"Tengo " + edad + " años"` (más verboso)

### Comentarios y Documentación
- **`//`**: Comentario de una línea
- **`/* ... */`**: Comentario de varias líneas
- **`///`**: Documentación XML (para generar documentación técnica)

## 11.3. Herramientas y Perfiles

### SDK y CLI
- **`dotnet new sln`**: Crea una solución
- **`dotnet new console`**: Crea un proyecto de consola
- **`dotnet sln add`**: Añade un proyecto a la solución
- **`dotnet build`**: Compila el proyecto
- **`dotnet run`**: Compila y ejecuta
- **`dotnet restore`**: Restaura paquetes NuGet

### NuGet
- **Gestor de paquetes** del ecosistema .NET
- Permite añadir librerías externas a nuestro proyecto
- Se gestiona desde el IDE o la CLI (`dotnet add package`)

### IDE
- **JetBrains Rider:** IDE profesional, recomendado para C#, Java, Python (de pago, gratuito para estudiantes)
- **Visual Studio Code:** Editor ligero, multiplataforma, gratuito
- **Visual Studio:** IDE completo de Microsoft (versión Community gratuita)

## 11.4. Errores Comunes a Evitar

| Error | Por qué está mal | Cómo evitarlo |
|-------|------------------|---------------|
| Olvidar `;` al final | C# es estricto con punto y coma | Revisar cada línea |
| Confundir `=` y `==` | `=` es asignación, `==` es comparación | Usar `==` en condiciones |
| División entre enteros | `10/3` da `3`, no `3.33` | Convertir a `double` antes: `(double)10/3` |
| No inicializar variables | Puede dar error al usarlas | Siempre asignar un valor al declarar |
| Usar `Parse` sin validar | Si el usuario no mete un número, salta excepción | Usar `TryParse` |
| Confundir `Write` y `WriteLine` | `Write` no salta de línea | `WriteLine` para nueva línea |
| Usar `int` para dinero | Pierde decimales (`10/3 = 3`) | Usar `decimal` para dinero |

## 11.5. Checklist de Supervivencia

Antes de dar por cerrado el tema, asegúrate de poder responder **SÍ** a estas preguntas:

- [ ] ¿Entiendo que un programa es una solución a un problema y no solo código?
- [ ] ¿Tengo claro que **siempre** hay que diseñar el algoritmo en papel ANTES de escribir código? (Análisis → Diseño → Codificación)
- [ ] ¿Sé la diferencia entre un algoritmo y un programa?
- [ ] ¿Recuerdo las 6 características de un algoritmo?
- [ ] ¿Sé explicar la diferencia entre compilado e interpretado?
- [ ] ¿Diferencio entre léxico, sintaxis y semántica?
- [ ] ¿Conozco los paradigmas: imperativo, estructurado, modular, POO, funcional, declarativo, eventos?
- [ ] ¿Sé crear una solución y un proyecto con la CLI?
- [ ] ¿Entiendo la diferencia entre `.slnx` y `.csproj`?
- [ ] ¿Sé usar Top-Level Statements en C# 14?
- [ ] ¿Conozco los tipos de datos: `int`, `long`, `float`, `double`, `decimal`, `bool`, `char`, `string`?
- [ ] ¿Sé la diferencia entre enteros con signo y sin signo?
- [ ] ¿Entiendo la diferencia entre `int` y `double` (y por qué no usar `int` para dinero)?
- [ ] ¿Tengo claro que `var` no significa que el tipo pueda cambiar luego?
- [ ] ¿Sé declarar variables y constantes?
- [ ] ¿Conozco los operadores aritméticos, relacionales, lógicos, de asignación, ternario y de coalescencia?
- [ ] ¿Sé la diferencia entre conversión implícita y explícita?
- [ ] ¿Sé usar `Console.WriteLine` y `Console.ReadLine`?
- [ ] ¿Conozco la interpolación de strings con `$""`?
- [ ] ¿Sé escribir comentarios de una línea, varias líneas y documentación XML?
- [ ] ¿Entiendo qué es `using static` y para qué sirve?
- [ ] ¿Recuerdo que `ReadLine()` siempre me da un `string` y debo convertirlo?
- [ ] ¿Sé usar `TryParse` en vez de `Parse` para entrada de usuario?

> 🔧 **Truco:** La mejor forma de aprender programación es practicando. No leas solo los apuntes: abre el IDE y prueba cada ejemplo. Modifícalos, rompelos, arreglalos. Eso es como se aprende.
