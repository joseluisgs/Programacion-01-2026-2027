- [4. Estructura de un Programa](#4-estructura-de-un-programa)
  - [4.1. Bloques que componen un programa](#41-bloques-que-componen-un-programa)
  - [4.2. Top-Level Statements (C# 14)](#42-top-level-statements-c-14)
  - [4.3. Estructura clásica vs moderna](#43-estructura-clásica-vs-moderna)
  - [4.4. Namespaces](#44-namespaces)
  - [4.5. Using static: comodidad en la escritura](#45-using-static-comodidad-en-la-escritura)
  - [4.6. El archivo .csproj](#46-el-archivo-csproj)
  - [4.7. El archivo .slnx](#47-el-archivo-slnx)
  - [4.8. Scripting en C#: lo primero que aprenderás](#48-scripting-en-c-lo-primero-que-aprenderás)
  - [4.9. Tu primer "Hola Mundo": paso a paso](#49-tu-primer-hola-mundo-paso-a-paso)
  - [4.10. Tabla de equivalencias: Pseudocódigo → C# → Java](#410-tabla-de-equivalencias-pseudocódigo--c--java)


# 4. Estructura de un Programa

> 💡 **Punto de partida:** ¿Alguna vez has visto un libro desordenado sin capítulos, sin índice, sin una estructura clara? Es difícil seguirlo. Lo mismo pasa con un programa sin estructura. Vamos a aprender a organizar nuestro código correctamente.

En este tema aprenderás cómo se estructura un programa en C#, qué son los bloques fundamentales, cómo usar Top-Level Statements y la diferencia entre `.slnx` y `.csproj`.

**Objetivos de aprendizaje:**

- Identificar los bloques que componen un programa informático
- Entender la estructura de un programa en C#
- Usar Top-Level Statements correctamente
- Comprender la diferencia entre `.slnx` y `.csproj`
- Usar `using static` para simplificar el código

## 4.1. Bloques que componen un programa

Un programa informático se compone de varios bloques fundamentales:

```mermaid
graph TB
    A[Programa] --> B[Sentencias]
    A --> C[Expresiones]
    A --> D[Métodos]
    A --> E[Bloques]

    style A fill:#2196F3,color:#fff
    style B fill:#4CAF50,color:#fff
    style C fill:#FF9800,color:#fff
    style D fill:#9C27B0,color:#fff
    style E fill:#f44336,color:#fff
```

### Sentencias

Una **sentencia** es una instrucción que realiza una acción. Es la unidad básica de ejecución. Todas terminan con **punto y coma (`;`)**.

```csharp
// Sentencia de declaración
int edad = 22;

// Sentencia de asignación
edad = 23;

// Sentencia de llamada a método
Console.WriteLine("Hola");

// Sentencia vacía (no hace nada, pero es válida)
;
```

> ⚠️ **Advertencia:** Olvidar el punto y coma al final es el error más común de los principiantes. C# es muy estricto con eso.

### Expresiones

Una **expresión** es un código que produce un valor. No es lo mismo que una sentencia.

```csharp
// Esto es una EXPRESIÓN (produce un valor)
5 + 3          // Resultado: 8
edad > 18      // Resultado: true
"Ana" + " Ana" // Resultado: "Ana Ana"

// Esto es una SENTENCIA (realiza una acción)
int resultado = 5 + 3;  // La expresión 5+3 se usa dentro de la sentencia
```

> 💡 **Analogía:** Una expresión es como una pregunta que tiene respuesta ("¿cuánto es 2+2?"). Una sentencia es como una orden ("suma 2+2 y guárdalo").

### Métodos (funciones)

Un **método** es un bloque de código reutilizable que realiza una tarea específica.

```csharp
// Método que no retorna valor (void)
void Saludar()
{
    Console.WriteLine("¡Hola!");
}

// Método que retorna un valor
int Sumar(int a, int b)
{
    return a + b;
}

// Uso
Saludar();                     // Llama al método
int suma = Sumar(5, 3);        // suma = 8
Console.WriteLine(suma);
```

### Bloques

Un **bloque** es un conjunto de sentencias encerradas entre llaves `{}`.

```csharp
// Este es un bloque
{
    int x = 5;
    int y = 10;
    int suma = x + y;
    Console.WriteLine(suma);  // 15
}
// x, y y suma ya no existen aquí
```

## 4.2. Top-Level Statements (C# 14)

**Top-Level Statements** es una característica introducida en C# 9 que permite escribir código sin la estructura tradicional de clases y métodos. Es la forma moderna y recomendada para empezar.

### Sin Top-Level Statements (antes)

```csharp
using System;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola, mundo!");
        }
    }
}
```

### Con Top-Level Statements (ahora)

```csharp
Console.WriteLine("¡Hola, mundo!");
```

**¡Es exactamente lo mismo!** Pero mucho más limpio y directo.

> 💡 **Analogía:** Top-Level Statements es como escribir una carta sin poner "Estimado señor:" al principio y "Atentamente, yo" al final. Va directo al contenido.

### ¿Cómo funciona por debajo?

El compilador de C# toma tu código y automáticamente lo envuelve en una clase con un método `Main`. Tú no lo ves, pero está ahí:

```csharp
// Lo que escribes (Top-Level):
Console.WriteLine("Hola");
int x = 5;

// Lo que el compilador genera internamente:
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola");
        int x = 5;
    }
}
```

### Reglas de Top-Level Statements

1. Solo puede haber **un archivo** con Top-Level Statements por proyecto
2. Las declaraciones van directamente, sin `class` ni `Main`
3. Los `using` van al inicio del archivo
4. Se pueden definir métodos y usar después

```csharp
using System;

// Esto es Top-Level
Console.WriteLine("Primero se ejecuta esto");

void DecirHola(string nombre)
{
    Console.WriteLine($"Hola, {nombre}!");
}

// Llamar al método definido arriba
DecirHola("Ana");
DecirHola("Carlos");
```

> ⚠️ **Advertencia:** Top-Level Statements es ideal para scripts, prototipos y proyectos pequeños. En proyectos grandes con muchas clases, se sigue usando la estructura tradicional.

📌 **Ejemplo real:** Cuando haces un script para convertir datos o automatizar una tarea, Top-Level Statements te permite escribir el código directamente sin burocracia.

## 4.3. Estructura clásica vs moderna

| Característica | Clásica (con Main) | Moderna (Top-Level) |
|----------------|---------------------|----------------------|
| **Sintaxis** | `class Program { static void Main() {} }` | Código directo |
| **Verbosidad** | Más código ceremonioso | Menos código, más legible |
| **Uso ideal** | Proyectos grandes, multi-clase | Scripts, prototipos, aprendizaje |
| **Métodos** | Se definen dentro de la clase | Se pueden definir y usar libremente |
| **Namespaces** | Se declaran explícitamente | Se pueden usar igual |

### Cuándo usar cada una

- **Top-Level Statements:** Scripts, ejemplos, aprendizaje, prototipos
- **Estructura clásica:** Proyectos reales, APIs, aplicaciones con múltiples clases

> 💡 **Consejo:** Empezaremos con Top-Level Statements para que te centres en aprender los conceptos sin preocuparte por la estructura. Cuando avancemos, veremos la estructura completa.

## 4.4. Namespaces

Un **namespace** (espacio de nombres) es como una "carpeta" que agrupa código relacionado y evita conflictos de nombres.

```csharp
// Sin namespaces, podrías tener dos clases "Cliente" que chocan
class Cliente { }  // ¿Cuál de las dos?

// Con namespaces, cada una está en su "carpeta"
namespace Tienda.Clientes
{
    class Cliente { }  // Este es el de clientes
}

namespace Tienda.Productos
{
    class Cliente { }  // Este es el de productos (confuso, pero válido)
}
```

### Usar namespaces

```csharp
// Declarar un namespace (file-scoped en C# 10+)
namespace MiProyecto.Models;

// Usar un namespace
using MiProyecto.Models;
```

> 📝 **Nota:** En C# 10+ se usa la sintaxis file-scoped con punto y coma: `namespace MiProyecto;` en vez de las llaves. Es más limpio.

### Namespaces implícitos

Gracias a `<ImplicitUsings>enable</ImplicitUsings>` en el `.csproj`, estos namespaces se importan automáticamente:

- `System`
- `System.Collections.Generic`
- `System.IO`
- `System.Linq`
- `System.Net.Http`
- `System.Threading`
- `System.Threading.Tasks`

No necesitas escribir `using System;` — ya está incluido.

> 📝 **Nota:** Si tu `.csproj` tiene `<ImplicitUsings>enable</ImplicitUsings>`, no necesitas poner `using System;` en cada archivo. El compilador lo incluye automáticamente. Si lo quitas, tendrás que escribir `using System;` en todos los archivos.

> ⚠️ **Advertencia:** El archivo principal de un proyecto de consola **siempre** se llama `Program.cs`. No le cambies el nombre, porque el compilador busca ese archivo específicamente para Top-Level Statements.

## 4.5. Using static: comodidad en la escritura

El `using static` te permite usar los miembros estáticos de una clase **sin escribir el nombre de la clase cada vez**. Es especialmente útil con `Console`.

### Sin using static (siempre escribiendo Console)

```csharp
Console.WriteLine("Hola");
Console.Write("¿Cómo te llamas? ");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola, {nombre}!");
Console.WriteLine("Introduce tu edad: ");
string texto = Console.ReadLine();
int edad = int.Parse(texto);
Console.WriteLine($"Tienes {edad} años");
```

### Con using static (mucho más limpio)

```csharp
using static System.Console;
using static System.Convert;

WriteLine("Hola");
Write("¿Cómo te llamas? ");
string nombre = ReadLine();
WriteLine($"Hola, {nombre}!");
WriteLine("Introduce tu edad: ");
string texto = ReadLine();
int edad = ToInt32(texto);
WriteLine($"Tienes {edad} años");
```

> 💡 **Analogía:** `using static` es como si en tu casa pudieras decir "enciende" en vez de "enciende la luz de la cocina". Es más corto, pero solo funciona si todos saben de qué luz hablas.

### Usos más comunes de using static

```csharp
// Console:Write y Console.WriteLine
using static System.Console;

// Convert:ToInt32, Convert:ToDouble, etc.
using static System.Convert;

// Math:Max, Math:Min, Math:Sqrt, etc.
using static System.Math;

WriteLine("Solo Write y WriteLine");
WriteLine($"El máximo de 5 y 10 es: {Max(5, 10)}");
WriteLine($"La raíz cuadrada de 16 es: {Sqrt(16)}");
```

> ⚠️ **Advertencia:** `using static` puede reducir la legibilidad si se abusa. Úsalo solo con clases que usas muy frecuentemente (como `Console`). No lo uses con clases que tengan nombres genéricos que puedan causar confusión.

## 4.6. El archivo .csproj

El `.csproj` es el archivo de configuración de un proyecto. Define qué framework usar, qué paquetes instalar y cómo compilar.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <LangVersion>14</LangVersion>
  </PropertyGroup>

</Project>
```

**Explicación de cada propiedad:**

| Propiedad | Descripción | Valor |
|-----------|-------------|-------|
| `OutputType` | Tipo de salida | `Exe` (ejecutable) o `Library` (biblioteca) |
| `TargetFramework` | Framework de destino | `net10.0` para .NET 10 |
| `ImplicitUsings` | Imports automáticos | `enable` para namespaces comunes |
| `Nullable` | Gestión estricta de nulos | `enable` (recomendado siempre) |
| `TreatWarningsAsErrors` | Avisos como errores | `true` (obliga a código limpio) |
| `LangVersion` | Versión del lenguaje C# | `14` para .NET 10, `15` para .NET 11 |

> 📝 **Nota:** En .NET 10 usamos C# 14. En .NET 11 usaremos C# 15. La propiedad `LangVersion` controla qué features del lenguaje están disponibles.

### Añadir paquetes NuGet al proyecto

```bash
# Desde la CLI
dotnet add package Newtonsoft.Json
```

El `.csproj` se actualiza automáticamente:

```xml
<ItemGroup>
  <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
</ItemGroup>
```

## 4.7. El archivo .slnx

El `.slnx` es el archivo de solución en el nuevo formato XML. Es más simple y legible que el antiguo `.sln`.

```xml
<Solution>
  <Project Path="MiPrimeraSolucion/MiPrimeraSolucion.csproj" />
</Solution>
```

**Con tests incluidos:**

```xml
<Solution>
  <Project Path="MiPrimeraSolucion/MiPrimeraSolucion.csproj" />
  <Project Path="MiPrimeraSolucion.Test/MiPrimeraSolucion.Test.csproj" />
</Solution>
```

> 📝 **Nota:** El formato `.slnx` es el nuevo estándar de .NET. El antiguo formato `.sln` sigue funcionando pero es más complejo.

## 4.8. Scripting en C# 14: lo primero que aprenderás

Desde .NET 10 con C# 14, podemos escribir y ejecutar código C# directamente como un script, sin necesidad de crear un proyecto (.csproj). Solo necesitas un archivo `.cs`:

```csharp
// Archivo: hola.cs
Console.WriteLine("¡Hola desde un script!");
Console.WriteLine($"2 + 3 = {2 + 3}");
```

Para ejecutarlo, solo necesitas un comando:

```bash
dotnet run hola.cs
```

> 💡 **Analogía:** Scripting es como escribir una nota rápida en un papel. No necesitas preparar un documento formal, solo escribes y ejecutas. El compilador crea un proyecto temporal en caché, compila y ejecuta automáticamente.

### Usar paquetes NuGet en scripts

Si necesitas usar un paquete externo, lo indicas con `#:package`:

```csharp
#:package Newtonsoft.Json

using Newtonsoft.Json;

var persona = new { Nombre = "Ana", Edad = 25 };
string json = JsonConvert.SerializeObject(persona);
Console.WriteLine(json);
```

### Usar SDKs en scripts

Para usar un SDK (como el web SDK para APIs mínimas), lo indicas con `#:sdk`:

```csharp
#:sdk Microsoft.NET.Sdk.Web

var app = WebApplication.Create(args);
app.MapGet("/", () => "Hola desde una API mínima");
app.Run();
```

📌 **Ejemplo real:** Los scripts de C# son ideales para automatizar tareas del sistema, probar ideas rápidas o aprender. Muchos administradores de sistemas los usan para renombrar archivos, convertir datos o hacer copias de seguridad.

### Diferencia entre script y proyecto

| Característica | Script (`.cs`) | Proyecto (`.csproj`) |
|----------------|-----------------|----------------------|
| **Archivos** | Uno o varios `.cs` | `Program.cs` + `.csproj` |
| **Compilación** | Automática en caché | Compila a ejecutable |
| **Uso** | Pruebas rápidas, scripts | Aplicaciones reales |
| **Rendimiento** | Más lento (compila cada vez) | Más rápido |
| **Distribución** | Necesita dotnet install | Ejecutable independiente |

> 📝 **Nota:** Más información sobre scripting en [C# Moves to Scripting (NetMentor)](https://www.netmentor.es/entrada/csharp-scripting).

## 4.9. Formato .slnx: el nuevo estándar

En .NET 10, el formato de solución por defecto es `.slnx` (XML-based), no el antiguo `.sln`. El nuevo formato es más simple y legible:

**Antes (.sln - formato antiguo):**
```
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.0.31903.59
...
```

**Ahora (.slnx - nuevo formato):**
```xml
<Solution>
  <Project Path="MiProyecto/MiProyecto.csproj" />
</Solution>
```

### Migrar de .sln a .slnx

Si tienes un proyecto antiguo con `.sln`, puedes migrar con un solo comando:

```bash
dotnet sln migrate
```

Esto genera un archivo `.slnx` a partir del `.sln` existente.

> ⚠️ **Advertencia:** Si tienes ambos archivos (`.sln` y `.slnx`) en la misma carpeta, debes especificar cuál usar: `dotnet build MiSolucion.slnx`. Si no, el compilador no sabe cuál elegir.

> 📝 **Nota:** Más información en [Introducing support for SLNX (Microsoft DevBlog)](https://devblogs.microsoft.com/dotnet/introducing-slnx-support-dotnet-cli/).

## 4.10. Tu primer "Hola Mundo": paso a paso

Ahora vamos a crear nuestro primer programa completo paso a paso. Sigue cada comando en orden:

**Paso 1: Crear la carpeta de la solución**

```bash
mkdir MiPrimeraSolucion
cd MiPrimeraSolucion
```

**Paso 2: Crear la solución (.slnx)**

```bash
dotnet new sln --name MiPrimeraSolucion
```

> 📝 **Nota:** En .NET 10 esto crea un archivo `.slnx` automáticamente.

**Paso 3: Crear el proyecto de consola**

```bash
dotnet new console --name MiPrimeraSolucion
```

> 📝 **Nota:** Esto crea una carpeta `MiPrimeraSolucion/` con un archivo `Program.cs` y un archivo `MiPrimeraSolucion.csproj`. **El archivo principal SIEMPRE se llama `Program.cs`** — no le cambies el nombre.

**Paso 4: Añadir el proyecto a la solución**

```bash
dotnet sln add MiPrimeraSolucion/MiPrimeraSolucion.csproj
```

**Paso 5: Verificar la estructura**

```bash
# Ver qué hemos creado
dir
# Verás: MiPrimeraSolucion.slnx y carpeta MiPrimeraSolucion/
```

**Paso 6: Abrir Program.cs y escribir el código**

Abre `MiPrimeraSolucion/Program.cs` en tu IDE y escribe:

```csharp
Console.WriteLine("¡Hola, mundo!");
Console.WriteLine("Mi primer programa en C#");
Console.WriteLine($"Hoy es {DateTime.Now:dd/MM/yyyy}");
```

**Paso 7: Compilar y ejecutar**

```bash
dotnet run
```

**Salida esperada:**

```
¡Hola, mundo!
Mi primer programa en C#
Hoy es 06/09/2026
```

> 🎉 **¡Enhorabuena!** Acaba de compilar y ejecutar tu primer programa en C#. El compilador Tomó tu `Program.cs`, lo tradujo a código intermedio (IL), y la CLR lo ejecutó en tu máquina.

📌 **Ejemplo real:** Este es exactamente el mismo proceso que seguirás para crear aplicaciones reales. La diferencia es que las aplicaciones reales tienen más código, más archivos y más complejidad, pero la base es la misma.

### Diferencia entre .slnx y .csproj

| Archivo | Función | Contenido |
|---------|---------|-----------|
| **`.slnx`** | Solución: agrupa proyectos | Referencias a archivos `.csproj` |
| **`.csproj`** | Proyecto: configura un programa | Framework, paquetes, opciones de compilación |

> 💡 **Analogía:** La solución (`.slnx`) es como el plan de estudios de un ciclo. El proyecto (`.csproj`) es como la programación didáctica de una asignatura. La solución agrupa varios proyectos relacionados.

### Crear soluciones y proyectos con la CLI

```bash
# 1. Crear carpeta para la solución
mkdir MiPrimeraSolucion
cd MiPrimeraSolucion

# 2. Crear la solución
dotnet new sln --name MiPrimeraSolucion

# 3. Crear el proyecto de consola
dotnet new console --name MiPrimeraSolucion

# 4. Añadir el proyecto a la solución
dotnet sln add MiPrimeraSolucion/MiPrimeraSolucion.csproj

# 5. Verificar que todo está correcto
dotnet sln list

# 6. Compilar y ejecutar
dotnet run
```

## 4.10. Tabla de equivalencias: Pseudocódigo → C# → Java

Si vienes de pseudocódigo o has visto Java, esta tabla te ayudará:

| Concepto | Pseudocódigo | C# | Java |
|----------|-------------|-----|------|
| **Punto de entrada** | `inicio` / `principal` | Top-Level Statements | `public static void main(String[] args)` |
| **Salida** | `writeLine()` / `imprimir()` | `Console.WriteLine()` | `System.out.println()` |
| **Entrada** | `readLine()` / `leer()` | `Console.ReadLine()` | `Scanner.nextLine()` |
| **Constantes** | `constante IVA = 21` | `const double Iva = 21.0;` | `final double IVA = 21.0;` |
| **Solo lectura** | `soloLectura` | `readonly` (en clases) | `final` |
| **Inferencia de tipo** | `variable x = 5` | `var x = 5;` | `var x = 5;` (Java 10+) |
| **Enumeración** | `enumerar DiasSemana` | `enum DiaSemana` | `enum DiaSemana` |
| **Estructura** | `Clase` | `class` | `class` |
| **Primitivos** | `entero`, `real`, `booleano` | `int`, `double`, `bool` | `int`, `double`, `boolean` |

> 💡 **Consejo:** C# es más parecido a Java que a pseudocódigo. Si vienes de Java, notarás que C# es más conciso (Top-Level Statements) y tiene más azúcar sintáctico (`var`, `??`, `$""`, etc.).

---

**Resumen del punto:**

| Concepto | Descripción |
|----------|-------------|
| **Sentencia** | Instrucción que realiza una acción (termina en `;`) |
| **Expresión** | Código que produce un valor |
| **Método** | Bloque de código reutilizable |
| **Bloque** | Conjunto de sentencias entre `{}` |
| **Top-Level Statements** | Código sin `class` ni `Main` (C# 9+) |
| **Namespace** | Agrupa código relacionado, evita conflictos |
| **using static** | Permite usar miembros estáticos sin nombre de clase |
| **`.csproj`** | Configuración del proyecto (framework, paquetes) |
| **`.slnx`** | Solución: agrupa varios proyectos |
| **`dotnet new`** | Crea proyectos y soluciones |
| **`dotnet build`** | Compila el proyecto |
| **`dotnet run`** | Compila y ejecuta |

En el siguiente punto veremos los tipos de datos en C#: enteros, decimales, texto, booleanos y la inferencia de tipos con `var`.
