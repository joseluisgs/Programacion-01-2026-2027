- [9. Entrada y Salida de Datos](#9-entrada-y-salida-de-datos)
  - [9.1. Salida de datos](#91-salida-de-datos)
    - [9.1.1. Console.Write y Console.WriteLine](#911-consolewrite-y-consolewriteline)
    - [9.1.2. Concatenación](#912-concatenación)
    - [9.1.3. Interpolación de strings (templates)](#913-interpolación-de-strings-templates)
  - [9.2. Entrada de datos](#92-entrada-de-datos)


# 9. Entrada y Salida de Datos

> 💡 **Punto de partida:** Un programa sin entrada ni salida es como un teléfono sin pantalla ni altavoz: no puedes interactuar con él. La entrada y salida son los canales de comunicación entre el programa y el usuario.

En este tema aprenderás a mostrar información por pantalla y a leer datos del teclado en C#.

> 🎮 **Proyecto Pokédex:** Pedimos al usuario el nombre, tipo y CP del Pokémon, y mostramos la información formateada con interpolación.

**Objetivos de aprendizaje:**

- Mostrar información por consola con `Console.Write` y `Console.WriteLine`
- Usar concatenación e interpolación de strings
- Leer datos del teclado con `Console.ReadLine`

> 📝 **Nota:** En esta unidad no usaremos manejo de excepciones. Cuando hagamos `Console.ReadLine`, asumiremos que el usuario introduce datos válidos. Más adelante veremos cómo validar y manejar errores.

## 9.1. Salida de datos

### 9.1.1. Console.Write y Console.WriteLine

C# dispone de dos métodos principales para sacar información por pantalla:

```csharp
// Console.WriteLine: escribe texto y salta de línea
Console.WriteLine("Hola, mundo");
Console.WriteLine("Esto es otra línea");

// Console.Write: escribe texto SIN saltar de línea
Console.Write("Hola ");
Console.Write("Mundo");
Console.WriteLine();  // Salto de línea manual
```

**Diferencia práctica:**

```csharp
// Con WriteLine (salta de línea automáticamente)
Console.WriteLine("Primera línea");
Console.WriteLine("Segunda línea");
// Salida:
// Primera línea
// Segunda línea

// Con Write (NO salta de línea)
Console.Write("Primera línea ");
Console.Write("y sigue aquí");
Console.WriteLine();
// Salida:
// Primera línea y sigue aquí
```

> 💡 **Consejo:** Usa `Console.WriteLine` la mayoría de las veces. Usa `Console.Write` cuando necesites que la siguiente salida aparezca en la misma línea (por ejemplo, al pedir datos).

### 9.1.2. Concatenación

La **concatenación** es unir strings con el operador `+`:

```csharp
string nombre = "Ana";
int edad = 25;

// Concatenación básica
string saludo = "Hola, " + nombre;
Console.WriteLine(saludo);  // "Hola, Ana"

// Concatenación con números (se convierten automáticamente a string)
string mensaje = "Tengo " + edad + " años";
Console.WriteLine(mensaje);  // "Tengo 25 años"

// Concatenación con expresiones
Console.WriteLine("El doble de " + edad + " es " + (edad * 2));
// "El doble de 25 es 50"
```

> ⚠️ **Advertencia:** La concatenación con `+` puede ser poco legible cuando hay muchos valores. En ese caso, usa la interpolación (siguiente sección).

### 9.1.3. Interpolación de strings (templates)

La **interpolación de strings** usa `$` y llaves `{}` para insertar valores directamente en un string. Es más legible que la concatenación.

```csharp
string nombre = "Ana";
int edad = 25;
double precio = 19.99;

// Interpolación: usar $ y {variable}
Console.WriteLine($"Hola, {nombre}");
Console.WriteLine($"Tengo {edad} años");
Console.WriteLine($"El precio es {precio} €");

// Expresiones dentro de {}
Console.WriteLine($"El doble de {edad} es {edad * 2}");
Console.WriteLine($"Mañana tendré {edad + 1} años");

// Formato de números
Console.WriteLine($"Precio: {precio:F2} €");  // 19.99
Console.WriteLine($"Porcentaje: {0.85:P0}");   // 85%
Console.WriteLine($"Número con separadores: {1000000:N0}");  // 1.000.000
```

### Alineación de strings

La interpolación permite **alinear** el texto dentro de un ancho fijo. La sintaxis es:

```csharp
{variable,ancho}
{variable,-ancho}   // negativo = alinear a la izquierda
{variable,ancho}    // positivo = alinear a la derecha
```

```csharp
string nombre = "Ana";
Console.WriteLine($"|{nombre,-10}|");  // |Ana       |  ← izquierda, 10 chars
Console.WriteLine($"|{nombre,10}|");   // |       Ana|  ← derecha, 10 chars
Console.WriteLine($"|{nombre,-20}|");  // |Ana                 |  ← más ancho
```

**¿Para qué sirve?** Para crear tablas alineadas en consola:

```csharp
string p1 = "Pikachu";
string p2 = "Charizard";
int cp1 = 2500;
int cp2 = 1200;

Console.WriteLine($"|{"Pokemon",-15} | {"CP",6} |");  // Cabecera
Console.WriteLine($"|{"───────────────",-15} | {"──────",6} |");
Console.WriteLine($"|{p1,-15} | {cp1,6} |");           // Pikachu alineado a izquierda
Console.WriteLine($"|{p2,-15} | {cp2,6} |");           // Charizard alineado a izquierda
```

Salida:
```
|Pokemon         |     CP |
|─────────────── | ------ |
|Pikachu         |   2500 |
|Charizard       |   1200 |
```

> 💡 **Consejo:** Usa negativo (`-15`) para texto (izquierda) y positivo (`6`) para números (derecha). Así las columnas quedan alineadas perfectamente.

> 💡 **Analogía:** La interpolación es como rellenar un formulario con campos predefinidos. En vez de escribir "Hola" + nombre + ", tienes" + edad + " años", escribes `$"Hola {nombre}, tienes {edad} años"`. Mucho más claro.

**Comparativa:**

```csharp
string nombre = "Ana";
int edad = 25;

// ❌ Concatenación (menos legible)
string msg1 = "Hola " + nombre + ", tienes " + edad + " años y el año que viene tendrás " + (edad + 1);

// ✅ Interpolación (más legible)
string msg2 = $"Hola {nombre}, tienes {edad} años y el año que viene tendrás {edad + 1}";
```

📌 **Ejemplo real:** Cuando ves un "Bienvenido, Juan" en una web, internamente el servidor está interpolando tu nombre en un template: `$"Bienvenido, {usuario.Nombre}"`.

## 9.2. Entrada de datos

Para leer datos del teclado se usa `Console.ReadLine()`:

```csharp
// Leer un string
Console.Write("¿Cómo te llamas? ");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola, {nombre}!");

// Leer un número (necesita conversión)
Console.Write("¿Cuántos años tienes? ");
string texto = Console.ReadLine();
int edad = int.Parse(texto);
Console.WriteLine($"Tienes {edad} años");
```

> 📝 **Nota:** `Console.ReadLine` siempre retorna un `string`. Si necesitas un número, debes convertirlo con `Parse` o `TryParse`.

**Flujo típico de entrada:**

```csharp
// 1. Mostrar mensaje
Console.Write("Introduce tu nombre: ");

// 2. Leer el string
string nombre = Console.ReadLine();

// 3. Mostrar el resultado
Console.WriteLine($"Hola, {nombre}!");
```

**Lectura de múltiples datos:**

```csharp
Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Ciudad: ");
string ciudad = Console.ReadLine();

Console.WriteLine($"{nombre}, {edad} años, vive en {ciudad}");
```

> ⚠️ **Advertencia:** `Console.ReadLine()` retorna `null` si se alcanza el final del flujo (EOF). En aplicaciones reales, siempre debemos comprobar si es `null`. En esta unidad, para simplificar, asumiremos que el usuario siempre introduce datos.

> 💡 **Consejo:** Cuando pidas datos numéricos, muestra un mensaje claro indicando qué tipo de dato esperas. Por ejemplo: "Introduce tu edad (número):".

### Otros métodos útiles de Console

```csharp
// Console.ReadKey: lee una tecla sin necesidad de Enter
Console.Write("Pulsa cualquier tecla para continuar...");
ConsoleKeyInfo tecla = Console.ReadKey();  // Espera una tecla
Console.WriteLine();  // Salto de línea después

// Environment.NewLine: salto de línea multiplataforma
string mensaje = "Primera línea" + Environment.NewLine + "Segunda línea";
Console.WriteLine(mensaje);
```

> 📝 **Nota:** `Environment.NewLine` es útil cuando construyes strings con saltos de línea fuera de `Console.WriteLine`. En Windows produce `\r\n`, en Linux `\n`.

---

**Resumen del punto:**

| Operación | Método/Operador | Ejemplo |
|-----------|-----------------|---------|
| **Salida con salto** | `Console.WriteLine()` | `Console.WriteLine("Hola")` |
| **Salida sin salto** | `Console.Write()` | `Console.Write("Hola ")` |
| **Concatenación** | `+` | `"Hola " + nombre` |
| **Interpolación** | `$""` | `$"Hola {nombre}"` |
| **Entrada** | `Console.ReadLine()` | `string input = Console.ReadLine()` |

En el siguiente punto veremos los comentarios y la documentación: comentarios de una línea, varias líneas y documentación XML.
