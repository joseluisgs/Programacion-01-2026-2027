- [10. Comentarios y Documentación](#10-comentarios-y-documentación)
  - [10.1. ¿Qué son los comentarios?](#101-qué-son-los-comentarios)
  - [10.2. Tipos de comentarios en C#](#102-tipos-de-comentarios-en-c)
  - [10.3. Cuándo usar comentarios](#103-cuándo-usar-comentarios)
  - [10.4. Documentación XML](#104-documentación-xml)
  - [10.5. Resumen](#105-resumen)


# 10. Comentarios y Documentación

> 💡 **Punto de partida:** ¿Alguna vez has vuelto a leer algo que escribiste hace meses y no entendías qué querías decir? A los programadores nos pasa lo mismo con nuestro código. Los comentarios son las "notas al margen" que nos ayudan a recordar por qué hicimos algo de una manera determinada.

En este tema aprenderás a documentar tu código con comentarios en C#.

**Objetivos de aprendizaje:**

- Escribir comentarios de una línea y multilínea
- Entender cuándo y cómo documentar el código
- Usar documentación XML para métodos y clases

## 10.1. ¿Qué son los comentarios?

Los **comentarios** son notas que el programador escribe en el código para explicar su funcionamiento. El compilador los **ignora completamente** — no afectan al programa.

> 💡 **Analogía:** Los comentarios son como las notas que escribes en los márgenes de un libro de texto. No forman parte del contenido, pero te ayudan a entenderlo mejor.

## 10.2. Tipos de comentarios en C#

### Comentario de una línea

Se escribe con `//` y afecta solo a la línea donde está:

```csharp
// Este es un comentario de una línea
int edad = 25;  // También puede ir al final de la línea

// Variable que almacena la edad del usuario
// Se usa para verificar si es mayor de edad
bool esMayorDeEdad = edad >= 18;
```

### Comentario de varias líneas

Se escribe entre `/*` y `*/`:

```csharp
/*
Este es un comentario
que puede ocupar
varias líneas.
Se usa para explicaciones largas.
*/

int x = 10;
int y = 20;
```

### Comentario de documentación XML

Se escribe con `///` y se usa para documentar clases, métodos y propiedades:

```csharp
/// <summary>
/// Calcula la suma de dos números enteros.
/// </summary>
/// <param name="a">Primer número a sumar.</param>
/// <param name="b">Segundo número a sumar.</param>
/// <returns>La suma de ambos números.</returns>
int Sumar(int a, int b)
{
    return a + b;
}
```

## 10.3. Cuándo usar comentarios

### ✅ BUENO: Comentar el "por qué"

```csharp
// Multiplicamos por 1.21 porque el IVA del 21% debe incluirse
// en el precio final para cumplir con la normativa fiscal
double precioConIva = precioBase * 1.21;
```

```csharp
// Saltamos el primer elemento porque es la cabecera del CSV
for (int i = 1; i < lineas.Length; i++)
{
    ProcesarLinea(lineas[i]);
}
```

### ❌ MALO: Comentar el "qué"

```csharp
// Sumar a y b
int suma = a + b;

// Incrementar contador en 1
contador++;

// Abrir el archivo
using (var file = File.OpenRead("datos.txt"))
{
    // Leer el archivo
    var contenido = File.ReadAllText("datos.txt");
}
```

> ⚠️ **Advertencia:** Si necesitas un comentario para explicar QUÉ hace el código, es probable que el código no sea suficientemente claro. En ese caso, refactoriza el código en vez de añadir un comentario.

### Malas prácticas

```csharp
// ❌ Comentarios obvios (no aportan nada)
int contador = 0;  // contador

// ❌ Comentarios desactualizados (peligroso)
// El IVA es del 16%
double iva = 0.21;  // ¡El comentario dice 16 pero el código dice 21!

// ❌ Código comentado (borrarlo, no comentarlo)
// int x = 5;
// Console.WriteLine(x);

// ✅ Solo comentarios que aportan valor
// El IVA varía según el tipo de producto: geral 21%, reducido 10%, superreducido 4%
double iva = CalcularIva(producto.Tipo);
```

> 💡 **Consejo:** Los comentarios son un mal necesario. El mejor comentario es código claro y autoexplicativo. Si tu código necesita muchos comentarios, probablemente necesite ser reescrito.

## 10.4. Documentación XML

La documentación XML se usa para generar documentación automática del código. Es especialmente útil en bibliotecas y proyectos grandes.

### Etiquetas más comunes

```csharp
/// <summary>
/// Descripción general del método o clase.
/// </summary>
/// <param name="nombre">Descripción del parámetro.</param>
/// <returns>Descripción de lo que retorna.</returns>
/// <example>
/// Ejemplo de uso:
/// <code>
/// int resultado = Sumar(5, 3);
/// </code>
/// </example>
```

### Ejemplo completo

```csharp
/// <summary>
/// Representa una persona con nombre y edad.
/// </summary>
public class Persona
{
    /// <summary>
    /// Nombre de la persona.
    /// </summary>
    public string Nombre { get; set; }

    /// <summary>
    /// Edad de la persona en años.
    /// </summary>
    public int Edad { get; set; }

    /// <summary>
    /// Crea una nueva instancia de Persona.
    /// </summary>
    /// <param name="nombre">Nombre de la persona.</param>
    /// <param name="edad">Edad de la persona (debe ser positiva).</param>
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    /// <summary>
    /// Verifica si la persona es mayor de edad.
    /// </summary>
    /// <returns>true si tiene 18 o más años, false en caso contrario.</returns>
    public bool EsMayorDeEdad()
    {
        return Edad >= 18;
    }
}
```

> 📝 **Nota:** En los IDEs como Rider o VS Code, la documentación XML aparece como tooltip cuando pasas el cursor sobre un método o clase. Es muy útil para la auto-documentación.

> 💡 **Consejo:** Documenta siempre las clases públicas, interfaces y métodos públicos. El código privado y los métodos internos no siempre necesitan documentación XML.

## 10.5. Resumen

| Tipo de comentario | Sintaxis | Uso |
|--------------------|----------|-----|
| **Una línea** | `// texto` | Explicaciones breves |
| **Varias líneas** | `/* texto */` | Explicaciones largas |
| **Documentación XML** | `/// <summary>` | Documentación de código |

| Buena práctica | Mala práctica |
|----------------|---------------|
| Comentar el "por qué" | Comentar el "qué" |
| Código autoexplicativo | Comentarios para tapar código malo |
| Documentación XML en públicos | Comentarios desactualizados |
| Código limpio sin comentarios innecesarios | Código comentado (borrarlo) |

> 💡 **Consejo para el examen:** Recuerda los tres tipos de comentarios y sabes cuándo usar cada uno. La regla de oro: comenta el "por qué", no el "qué".
