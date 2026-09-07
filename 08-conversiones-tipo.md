- [8. Conversiones de Tipo](#8-conversiones-de-tipo)
  - [8.1. ¿Qué es una conversión de tipo?](#81-qué-es-una-conversión-de-tipo)
  - [8.2. Conversiones implícitas](#82-conversiones-implícitas)
  - [8.3. Conversiones explícitas (casting)](#83-conversiones-explícitas-casting)
  - [8.4. Métodos de conversión](#84-métodos-de-conversión)
  - [8.5. Errores comunes](#85-errores-comunes)


# 8. Conversiones de Tipo

> 💡 **Punto de partida:** Imagina que tienes una botella grande llena de agua y intentas verterla en un vaso pequeño. Alguno se derrama. Las conversiones de tipo son similares: a veces puedes convertir un tipo en otro sin problemas, y a veces pierdes datos o el compilador te lo prohíbe.

En este tema aprenderás a convertir entre tipos de datos de forma implícita y explícita.

**Objetivos de aprendizaje:**

- Entender qué son las conversiones de tipo
- Diferenciar conversiones implícitas y explícitas
- Usar métodos de conversión como `Parse`, `TryParse` y `Convert`
- Evitar errores comunes en conversiones

## 8.1. ¿Qué es una conversión de tipo?

Una **conversión de tipo** es cambiar un valor de un tipo a otro. Por ejemplo, convertir un `int` a un `double`, o un `string` a un `int`.

```csharp
int entero = 42;
double decimal = entero;  // Conversión: int → double (implícita)

string texto = "42";
int numero = int.Parse(texto);  // Conversión: string → int (explícita)
```

> 💡 **Analogía:** Es como cambiar la unidad de medida. 42 metros es lo mismo que 4200 centímetros. El valor "real" no cambia, solo la representación.

## 8.2. Conversiones implícitas

Las conversiones implícitas las hace el compilador **automáticamente** cuando no hay riesgo de perder datos. Se denominan "conversiones seguras".

```csharp
// int (4 bytes) → long (8 bytes): seguro, cabe más
int entero = 42;
long largo = entero;  // ✅ Implícita, sin problemas

// float (4 bytes) → double (8 bytes): seguro
float precio = 19.99f;
double doble = precio;  // ✅ Implícita

// char (2 bytes) → int (4 bytes): seguro
char letra = 'A';
int codigo = letra;  // ✅ Implícita (65 es el código ASCII de 'A')
```

**Regla general:** Si el tipo destino tiene **más capacidad** que el origen, la conversión es implícita.

| Desde | Hacia | Implícita |
|-------|-------|-----------|
| `sbyte` | `short`, `int`, `long`, `float`, `double`, `decimal` | ✅ |
| `byte` | `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal` | ✅ |
| `short` | `int`, `long`, `float`, `double`, `decimal` | ✅ |
| `ushort` | `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal` | ✅ |
| `int` | `long`, `float`, `double`, `decimal` | ✅ |
| `uint` | `long`, `ulong`, `float`, `double`, `decimal` | ✅ |
| `long` | `float`, `double`, `decimal` | ✅ |
| `float` | `double` | ✅ |

> 📝 **Nota:** `int` a `float` es implícita pero puede perder precisión. Un `int` grande puede no representarse exactamente como `float`.

## 8.3. Conversiones explícitas (casting)

Las conversiones explícitas requieren que el programador indique intencionadamente la conversión con un **cast**. Se usan cuando hay riesgo de perder datos.

```csharp
// double (8 bytes) → int (4 bytes): puede perder decimales
double pi = 3.14;
int entero = (int)pi;  // ✅ Entero = 3 (se trunca, no redondea)

// long (8 bytes) → int (4 bytes): puede perder datos
long grande = 3_000_000_000L;
int pequeno = (int)grande;  // ⚠️ Overflow: resultado inesperado
```

> ⚠️ **Advertencia:** El casting **trunca** (corta la parte decimal), no redondea. `(int)3.99` da `3`, no `4`.

### Casting seguro con checked

Para detectar overflows, puedes usar `checked`:

```csharp
long grande = 3_000_000_000L;

try
{
    int pequeno = checked((int)grande);  // Lanza OverflowException
}
catch (OverflowException)
{
    Console.WriteLine("El valor es demasiado grande para un int");
}
```

## 8.4. Métodos de conversión

Además del casting, C# ofrece métodos para convertir entre tipos, especialmente entre `string` y otros tipos.

### Parse y TryParse

```csharp
// Parse: convierte string a otro tipo (lanza excepción si falla)
string texto = "42";
int numero = int.Parse(texto);          // 42
double decimal = double.Parse("3.14");  // 3.14

// ❌ Si el string no es válido, lanza FormatException
int error = int.Parse("hola");  // Excepción
```

```csharp
// TryParse: no lanza excepción, retorna true/false
string texto = "42";
bool exito = int.TryParse(texto, out int resultado);

if (exito)
{
    Console.WriteLine($"El número es: {resultado}");
}
else
{
    Console.WriteLine("No es un número válido");
}

// Con valor por defecto si falla
string input = "abc";
int valor = int.TryParse(input, out int r) ? r : 0;  // valor = 0
```

> 💡 **Consejo:** Usa `TryParse` siempre que recibas datos de usuario. Es más seguro que `Parse` porque no provoca excepciones.

### Convert

La clase `Convert` ofrece métodos para convertir entre tipos:

```csharp
// Convertir a diferentes tipos
int entero = 42;
double doble = Convert.ToDouble(entero);    // 42.0
string texto = Convert.ToString(entero);     // "42"
bool booleano = Convert.ToBoolean(1);        // true

// Convertir desde string
string precio = "19.99";
double precioDouble = Convert.ToDouble(precio);  // 19.99
```

> 📝 **Nota:** `Convert` es más tolerante que `Parse`. Por ejemplo, `Convert.ToInt32(null)` retorna `0`, mientras que `int.Parse(null)` lanza excepción.

### Conversión con ChangeType

`Convert.ChangeType` permite convertir entre tipos de forma genérica (cuando no sabes el tipo en tiempo de compilación):

```csharp
object valor = "42";
int entero = Convert.ToInt32(valor);     // 42
double doble = Convert.ToDouble(valor);  // 42.0

// Útil con tipos dinámicos
Type tipoDestino = typeof(double);
object resultado = Convert.ChangeType(valor, tipoDestino);  // 42.0
```

### Conversión con el operador `as`

El operador `as` intenta convertir un tipo a otro. Si falla, retorna `null` en vez de lanzar excepción:

```csharp
object texto = "Hola";
string cadena = texto as string;  // "Hola" — funciona

object entero = 42;
string falla = entero as string;  // null — no compila, pero no lanza excepción

// Uso típico: comprobar antes de usar
if (texto is string mensaje)
{
    Console.WriteLine(mensaje);  // "Hola"
}
```

> 💡 **Consejo:** `as` solo funciona con tipos de referencia o nullable. Para tipos de valor, usa `is` con pattern matching o un cast explícito.

### Conversión con expresiones

```csharp
// Usando variables
int edad = 25;
double edadDouble = (double)edad;  // 25.0

// Usando literales
double pi = 3.14;
int truncado = (int)pi;  // 3

// String interpolation ya hace conversión automática
int puntos = 100;
Console.WriteLine($"Tienes {puntos} puntos");  // ToString() implícito
```

## 8.5. Errores comunes

```csharp
// ❌ ERROR 1: Usar Parse sin validar
string input = Console.ReadLine();  // El usuario puede escribir cualquier cosa
int numero = int.Parse(input);      // Excepción si no es número

// ✅ SOLUCIÓN: Usar TryParse
string input = Console.ReadLine();
if (int.TryParse(input, out int numero))
{
    Console.WriteLine($"Número: {numero}");
}
else
{
    Console.WriteLine("No es un número válido");
}
```

```csharp
// ❌ ERROR 2: Overflow sin detectar
byte pequeno = 255;
int grande = pequeno + 10;  // 265, pero byte solo llega a 255

// ✅ SOLUCIÓN: Usar el tipo adecuado
int resultado = pequeno + 10;  // OK, el resultado es int
```

```csharp
// ❌ ERROR 3: División entre enteros
int a = 10;
int b = 3;
double resultado = a / b;  // 3.0, no 3.333...

// ✅ SOLUCIÓN: Convertir antes de dividir
double resultado = (double)a / b;  // 3.333...
```

> 💡 **Consejo:** Los errores de conversión son de los más comunes en programación. Siempre valida los datos antes de convertirlos.

---

**Resumen del punto:**

| Tipo de conversión | Cómo se hace | Cuándo usar |
|--------------------|--------------|-------------|
| **Implícita** | Automática (compilador) | Cuando no hay riesgo de pérdida |
| **Explícita (cast)** | `(tipo)valor` | Cuando hay riesgo y tú controlas |
| **Parse** | `tipo.Parse(string)` | Cuando el string es válido (lanza excepción) |
| **TryParse** | `tipo.TryParse(string, out resultado)` | Con datos de usuario (seguro) |
| **Convert** | `Convert.ToTipo(valor)` | Conversión general, tolerante con null |

En el siguiente punto veremos la entrada y salida de datos: WriteLine, ReadLine, interpolación de strings y concatenación.
