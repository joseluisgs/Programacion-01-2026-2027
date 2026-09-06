- [3. Soluciones y Proyectos](#3-soluciones-y-proyectos)
  - [3.1. ¿Qué es una solución?](#31-qué-es-una-solución)
  - [3.2. ¿Qué es un proyecto?](#32-qué-es-un-proyecto)
  - [3.3. Estructura de archivos](#33-estructura-de-archivos)
    - [¿Qué hay dentro de cada carpeta?](#qué-hay-dentro-de-cada-carpeta)
  - [3.4. Crear soluciones y proyectos con la CLI](#34-crear-soluciones-y-proyectos-con-la-cli)
    - [Resultado de `dotnet sln list`:](#resultado-de-dotnet-sln-list)
    - [Comandos útiles de `dotnet sln`](#comandos-útiles-de-dotnet-sln)
  - [3.5. El archivo .csproj](#35-el-archivo-csproj)
    - [Añadir paquetes NuGet al proyecto](#añadir-paquetes-nuget-al-proyecto)
  - [3.6. El archivo .slnx](#36-el-archivo-slnx)
  - [3.7. Compilar y ejecutar](#37-compilar-y-ejecutar)
    - [El proceso de compilación](#el-proceso-de-compilación)
    - [Comandos de compilación](#comandos-de-compilación)
  - [3.8. Resumen](#38-resumen)


# 3. Soluciones y Proyectos

> 💡 **Punto de partida:** ¿Alguna vez has organizado tus apuntes en carpetas y subcarpetas? En programación hacemos lo mismo: agrupamos el código en soluciones y proyectos para mantenerlo ordenado. Sin esta organización, trabajar en un proyecto real sería un caos.

En este tema aprenderás la diferencia entre solución y proyecto, cómo crearlos con la CLI y cómo se organizan los archivos.

**Objetivos de aprendizaje:**

- Diferenciar entre solución y proyecto
- Crear soluciones y proyectos desde la línea de comandos
- Entender la estructura de archivos de un proyecto
- Conocer los archivos de configuración `.slnx` y `.csproj`

## 3.1. ¿Qué es una solución?

Una **solución** es un contenedor que agrupa uno o varios proyectos relacionados. Es como una "carpeta maestra" que contiene todo lo relacionado con un sistema de software. La solución tiene un archivo de configuración (`.slnx`) que referencia a los proyectos que contiene.

> 💡 **Analogía:** Una solución es como el plan de estudios de un ciclo formativo. Dentro tienes varias asignaturas (proyectos), cada una con su propio contenido, pero todas relacionadas con el mismo ciclo.

**Ejemplo práctico:**

Una aplicación de tienda online podría tener:
- **Solución:** `TiendaOnline`
  - **Proyecto:** `TiendaOnline.Web` (la aplicación web)
  - **Proyecto:** `TiendaOnline.Core` (la lógica de negocio)
  - **Proyecto:** `TiendaOnline.Test` (los tests)

## 3.2. ¿Qué es un proyecto?

Un **proyecto** es un conjunto de archivos de código que se compilan juntos para crear un programa o una biblioteca. Cada proyecto tiene su propio archivo de configuración (`.csproj`).

> 💡 **Analogía:** Un proyecto es como una asignatura. Tiene su propio contenido (archivos .cs), su configuración (`.csproj`) y produce un resultado al final (un ejecutable o una biblioteca).

**Tipos de proyecto más comunes:**

| Tipo | Descripción | Plantilla CLI |
|------|-------------|---------------|
| **Console** | Programa de consola | `dotnet new console` |
| **Class Library** | Biblioteca de clases reutilizable | `dotnet new classlib` |
| **Web API** | API REST | `dotnet new webapi` |
| **xUnit/NUnit** | Proyecto de tests | `dotnet new xunit` |

## 3.3. Estructura de archivos

La estructura que usamos sigue el formato estándar:

```
NombreSolucion/
├── NombreSolucion.slnx          # Archivo de solución
├── NombreSolucion/              # Proyecto principal
│   ├── NombreSolucion.csproj    # Configuración del proyecto
│   ├── Program.cs               # Punto de entrada del programa
│   ├── Models/                  # Modelos de datos
│   ├── Services/                # Lógica de negocio
│   └── ...
└── NombreSolucion.Test/         # Proyecto de tests (opcional)
    ├── NombreSolucion.Test.csproj
    └── ...
```

> ⚠️ **Advertencia:** La carpeta de la solución y la del proyecto deben tener **el mismo nombre**. Esto es una convención de .NET que facilita la organización.

### ¿Qué hay dentro de cada carpeta?

| Archivo/Carpeta | Descripción |
|-----------------|-------------|
| `.slnx` | Referencia a los proyectos de la solución |
| `.csproj` | Configuración del proyecto (framework, paquetes, etc.) |
| `Program.cs` | Código fuente principal |
| `bin/` | Código compilado (NO subir a Git) |
| `obj/` | Archivos temporales de compilación (NO subir a Git) |

## 3.4. Crear soluciones y proyectos con la CLI

Vamos a crear una solución paso a paso:

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

# 6. Compilar
dotnet build

# 7. Ejecutar
dotnet run
```

### Resultado de `dotnet sln list`:

```
Proyectos en la solución MiPrimeraSolucion:
  MiPrimeraSolucion/MiPrimeraSolucion.csproj
```

> 💡 **Consejo:** Siempre crea primero la solución y luego los proyectos dentro. Esto mantiene todo organizado desde el principio.

### Comandos útiles de `dotnet sln`

```bash
# Listar proyectos en la solución
dotnet sln list

# Añadir un proyecto
dotnet sln add ruta/al/proyecto.csproj

# Eliminar un proyecto
dotnet sln remove ruta/al/proyecto.csproj
```

## 3.5. El archivo .csproj

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

| Propiedad | Descripción |
|-----------|-------------|
| `OutputType` | Tipo de salida: `Exe` (ejecutable) o `Library` (biblioteca) |
| `TargetFramework` | Framework de destino: `net10.0` para .NET 10 |
| `ImplicitUsings` | Habilita imports automáticos de los namespaces más usados |
| `Nullable` | Habilita la gestión estricta de nulos (recomendado siempre) |
| `TreatWarningsAsErrors` | Convierte avisos en errores (obliga a código limpio) |
| `LangVersion` | Versión del lenguaje C#: `14` para .NET 10 |

> 📝 **Nota:** En .NET 10 usamos C# 14. En .NET 11 usaremos C# 15. La propiedad `LangVersion` controla qué características del lenguaje están disponibles.

### Añadir paquetes NuGet al proyecto

```bash
# Desde la CLI
dotnet add package Newtonsoft.Json

# El .csproj se actualiza automáticamente:
```

```xml
<ItemGroup>
  <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
</ItemGroup>
```

## 3.6. El archivo .slnx

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

## 3.7. Compilar y ejecutar

### El proceso de compilación

Cuando compilas un proyecto C#, ocurre esto:

1. **Roslyn (compilador)** lee tu código `.cs`
2. Lo traduce a **Intermediate Language (IL)**, un código intermedio
3. Se genera un archivo **ensamblado** (`.dll`) en la carpeta `bin/`
4. La **CLR** ejecuta el ensamblado con el JIT (Just-In-Time)

```mermaid
graph LR
    A[Código .cs] -->|Roslyn| B[Código IL]
    B -->|JIT| C[Código máquina]
    C -->|Ejecución| D[Programa funcionando]

    style A fill:#2196F3,color:#fff
    style B fill:#FF9800,color:#fff
    style C fill:#9C27B0,color:#fff
    style D fill:#4CAF50,color:#fff
```

### Comandos de compilación

```bash
# Compilar (genera archivos en bin/)
dotnet build

# Compilar en modo Release (optimizado)
dotnet build --configuration Release

# Ejecutar
dotnet run

# Limpiar archivos de compilación
dotnet clean

# Restaurar paquetes NuGet
dotnet restore
```

> 💡 **Consejo:** Usa `dotnet run` para desarrollo rápido. Usa `dotnet build` cuando solo quieras verificar que el código compila sin errores.

## 3.8. Resumen

| Concepto | Descripción |
|----------|-------------|
| **Solución** | Contenedor de proyectos relacionados (`.slnx`) |
| **Proyecto** | Conjunto de código que se compila junto (`.csproj`) |
| **`.csproj`** | Configuración del proyecto (framework, paquetes, opciones) |
| **`.slnx`** | Referencia a los proyectos de la solución |
| **`dotnet new`** | Crea proyectos y soluciones |
| **`dotnet build`** | Compila el proyecto |
| **`dotnet run`** | Compila y ejecuta |
| **Roslyn** | Compilador de C# |
| **CLR** | Máquina virtual que ejecuta el código |

> 💡 **Consejo para el examen:** Recuerda la diferencia entre solución y proyecto, y la estructura de archivos. También saber para qué sirve cada archivo (.slnx, .csproj, Program.cs).
