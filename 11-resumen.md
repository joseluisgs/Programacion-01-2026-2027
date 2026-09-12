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
  - [11.6. Glosario de Términos](#116-glosario-de-términos)
  - [11.7. Ejercicios de Repaso](#117-ejercicios-de-repaso)
  - [11.8. Mapa de Conexiones entre Temas](#118-mapa-de-conexiones-entre-temas)
  - [11.9. ¿Qué viene después?](#119-qué-viene-después)


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
    UD01 --> FLUJO["Flujo E→P→S"]
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
    UD01 --> POK[Proyecto Pokedex]

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
    COM --> CO2[varias lineas]
    COM --> CO3[/// documentacion XML]

    POK --> PK1[Nombre, Tipo, CP]
    POK --> PK2[Nivel, IV, Leyenda]
    POK --> PK3[Entrada → Proceso → Salida]
```

## 11.2. Conceptos Clave

### Fundamentos de la Programación
- **Programar:** Escribir instrucciones que el ordenador pueda ejecutar para resolver un problema
- **Algoritmo:** Plan ordenado de pasos para resolver un problema, independiente del lenguaje
- **Programa:** Implementación de un algoritmo en un lenguaje de programación concreto
- **Algoritmo vs Programa:** El algoritmo es el plano, el programa es la casa construida
- **Metáfora cocina:** Ingredientes (datos) → Receta (algoritmo) → Utensilios (operadores) → Plato (resultado)

### Flujo de un programa
- **Entrada → Proceso → Salida** (E→P→S): patrón universal de todo programa
- **Entrada:** `Console.ReadLine()` recibe datos del usuario
- **Proceso:** operaciones, cálculos, decisiones
- **Salida:** `Console.WriteLine()` muestra resultados

### Algoritmos
- **Finito:** Termina en algún momento (no es un bucle infinito)
- **Definido:** Cada paso está claramente definido (no hay ambigüedad)
- **Preciso:** Instrucciones exactas (no "más o menos")
- **Entrada:** Tiene datos de entrada (parámetros)
- **Salida:** Produce un resultado
- **Efectividad:** Cada paso es realizable
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
- **TryParse:** Convierte string a tipo. Devuelve `true/false` (**el seguro**)
- **Convert:** Convierte entre tipos básicos. Tolerante con null
- **Tabla de decisión:** Con datos de usuario → **siempre TryParse**

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
- **Trabajo en equipo:** Comentar el "por qué", no el "qué"
- **Regla:** Código autoexplicativo + comentarios donde aportan valor

### Proyecto Integrador: Pokédex
- **Metáfora:** Cocina (ingredientes → receta → utensilios → plato)
- **Flujo:** Entrada (datos usuario) → Proceso (cálculos) → Salida (mostrar)
- **Tipos:** `string` (nombre), `int` (CP), `double` (nivel), `bool` (leyenda)
- **Conversión:** `TryParse` para leer datos del usuario
- **Resultado:** Programa completo que pide, calcula y muestra información de un Pokémon

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
- [ ] ¿Recuerdo la metáfora de la cocina? (ingredientes, receta, utensilios, plato)
- [ ] ¿Sé la diferencia entre un algoritmo y un programa?
- [ ] ¿Recuerdo las 6 características de un algoritmo?
- [ ] ¿Sé explicar la diferencia entre compilado e interpretado?
- [ ] ¿Diferencio entre léxico, sintaxis y semántica?
- [ ] ¿Conozco los paradigmas: imperativo, estructurado, modular, POO, funcional, declarativo, eventos?
- [ ] ¿Sé crear una solución y un proyecto con la CLI?
- [ ] ¿Entiendo la diferencia entre `.slnx` y `.csproj`?
- [ ] ¿Sé usar Top-Level Statements en C# 14?
- [ ] ¿Entiendo el flujo Entrada → Proceso → Salida?
- [ ] ¿Conozco los tipos de datos: `int`, `long`, `float`, `double`, `decimal`, `bool`, `char`, `string`?
- [ ] ¿Sé la diferencia entre enteros con signo y sin signo?
- [ ] ¿Entiendo la diferencia entre `int` y `double` (y por qué no usar `int` para dinero)?
- [ ] ¿Tengo claro que `var` no significa que el tipo pueda cambiar luego?
- [ ] ¿Sé declarar variables y constantes?
- [ ] ¿Conozco los operadores aritméticos, relacionales, lógicos, de asignación, ternario y de coalescencia?
- [ ] ¿Entiendo la precedencia de operadores y por qué debo usar paréntesis cuando dude?
- [ ] ¿Sé la diferencia entre conversión implícita y explícita?
- [ ] ¿Conozco la tabla de decisión de conversiones? (Parse, TryParse, Convert, cast)
- [ ] ¿Sé usar `Console.WriteLine` y `Console.ReadLine`?
- [ ] ¿Conozco la interpolación de strings con `$""`?
- [ ] ¿Sé escribir comentarios de una línea, varias líneas y documentación XML?
- [ ] ¿Entiendo qué es `using static` y para qué sirve?
- [ ] ¿Recuerdo que `ReadLine()` siempre me da un `string` y debo convertirlo?
- [ ] ¿Sé usar `TryParse` en vez de `Parse` para entrada de usuario?
- [ ] ¿He creado la Pokédex y entiendo cómo cada tema contribuye al proyecto?

> 🔧 **Truco:** La mejor forma de aprender programación es practicando. No leas solo los apuntes: abre el IDE y prueba cada ejemplo. Modifícalos, rompelos, arreglalos. Eso es como se aprende.

## 11.6. Glosario de Términos

| Término | Definición |
|---------|------------|
| **Programar** | Escribir instrucciones que el ordenador pueda ejecutar |
| **Algoritmo** | Secuencia finita, ordenada y definida de pasos para resolver un problema |
| **Programa** | Implementación de un algoritmo en un lenguaje de programación |
| **Paradigma** | Estilo o forma de programar (imperativo, POO, funcional...) |
| **Sintaxis** | Reglas de construcción del código |
| **Semántica** | Significado de las construcciones del código |
| **SDK** | Software Development Kit: kit de desarrollo completo |
| **CLI** | Command Line Interface: línea de comandos |
| **NuGet** | Gestor de paquetes del ecosistema .NET |
| **IDE** | Entorno de Desarrollo Integrado (editor + compilador + depurador) |
| **Top-Level Statements** | Código sin `class` ni `Main` (C# 9+) |
| **Namespace** | Espacio de nombres que agrupa código relacionado |
| **Variable** | Contenedor con nombre que almacena un dato que puede cambiar |
| **Constante** | Contenedor que NO puede cambiar su valor (`const`) |
| **Literal** | Valor fijo en el código (`42`, `"Hola"`, `true`) |
| **Enum** | Conjunto de valores con nombre (`enum DiaSemana`) |
| **Expresión** | Código que produce un valor |
| **Sentencia** | Instrucción que realiza una acción (termina en `;`) |
| **Método** | Bloque de código reutilizable que realiza una tarea |
| **Interpolación** | Sustitución de variables en strings con `$""` |
| **Parse** | Convierte string a tipo (lanza excepción si falla) |
| **TryParse** | Convierte string a tipo (retorna `true/false`, seguro) |
| **Casting** | Conversión explícita de un tipo a otro (`(int)pi`) |
| **Precedencia** | Orden en que se evalúan los operadores en una expresión |
| **Scope** | Ámbito donde es visible una variable |
| **De Morgan** | Leyes lógicas para simplificar negaciones |

## 11.7. Ejercicios de Repaso

1. **Algoritmos:** Escribe en pseudocódigo un algoritmo que pida 2 números al usuario y muestre la suma, resta, multiplicación y división.

2. **Tipos de datos:** Clasifica `int`, `double`, `decimal`, `string`, `bool`, `char`, `byte` según: tamaño, uso típico y si tiene signo.

3. **Variables y constantes:** Declara las variables necesarias para modelar un alumno (nombre, edad, nota media, aprobado). Crea una constante para el número total de alumnos.

4. **Operadores:** Sin ejecutar, predice el resultado de cada expresión:
   - `10 / 3`
   - `10.0 / 3`
   - `17 % 5`
   - `true || false && !true`

5. **Conversiones:** Escribe un programa que pida la temperatura en Fahrenheit y la convierta a Celsius usando la fórmula: `C = (F - 32) * 5 / 9`.

6. **Entrada y salida:** Crea un programa que pida nombre, apellidos y edad, y muestre: "Hola, [nombre] [apellidos]. Tienes [edad] años. Tendrás [edad+10] en 10 años."

7. **Comentarios:** Comenta el siguiente código explicando el "por qué", no el "qué":
   ```csharp
   int resultado = (precio * 1.21) - descuento;
   ```

## 11.8. Mapa de Conexiones entre Temas

```mermaid
graph LR
    P01[P01: Que es programar] --> P02[P02: Entorno .NET]
    P02 --> P03[P03: Soluciones y Proyectos]
    P03 --> P04[P04: Estructura del Programa]
    P04 --> P05[P05: Tipos de Datos]
    P05 --> P06[P06: Variables y Constantes]
    P06 --> P07[P07: Operadores]
    P07 --> P08[P08: Conversiones]
    P08 --> P09[P09: Entrada y Salida]
    P09 --> P10[P10: Comentarios]
    P10 --> P11[P11: Resumen]

    P01 -.->|define| P04
    P05 -.->|se usan en| P06
    P06 -.->|se operan con| P07
    P07 -.->|requieren| P08
    P08 -.->|para leer/escribir| P09
    P09 -.->|se documentan con| P10

    style P01 fill:#4CAF50,color:#fff
    style P04 fill:#2196F3,color:#fff
    style P05 fill:#FF9800,color:#fff
    style P09 fill:#9C27B0,color:#fff
    style P11 fill:#f44336,color:#fff
```

> 📝 **Nota:** Todos los puntos están interconectados. No son puntos sueltos: son piezas de un mismo puzzle. La Programación es un todo donde cada concepto alimenta a los demás.

## 11.9. ¿Qué viene después?

En la **UD02: Entornos de Desarrollo** profundizaremos en las herramientas concretas que usarás como desarrollador: cómo configurar tu entorno de trabajo, dominar el IDE, y gestionar proyectos con Git. Pasaremos de la teoría a la práctica real del día a día.
