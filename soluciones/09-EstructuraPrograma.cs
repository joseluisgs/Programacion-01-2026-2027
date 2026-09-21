// 08-StructuraPrograma.cs
// Ejemplo: Estructura de un programa — bloques, sentencias, expresiones, métodos.
// Ejecutar: dotnet run 08-StructuraPrograma.cs

Console.WriteLine("=== ESTRUCTURA DE UN PROGRAMA ===");
Console.WriteLine();

// --- Sentencias ---
Console.WriteLine("--- Sentencias (instrucciones que terminan en ;) ---");
int edad = 22;         // Sentencia de declaración
edad = 23;             // Sentencia de asignación
Console.WriteLine(edad); // Sentencia de llamada a método
Console.WriteLine("  Cada línea que termina en ; es una sentencia");
Console.WriteLine();

// --- Expresiones ---
Console.WriteLine("--- Expresiones (código que produce un valor) ---");
int suma = 5 + 3;        // 5 + 3 es una expresión
bool mayorQue = edad > 18; // edad > 18 es una expresión
string texto = "Ana" + " García"; // concatenación es expresión

Console.WriteLine($"  5 + 3 = {suma}  (expresión numérica)");
Console.WriteLine($"  {edad} > 18 = {mayorQue}  (expresión booleana)");
Console.WriteLine($"  \"Ana\" + \" García\" = \"{texto}\"  (expresión de texto)");
Console.WriteLine();

// --- Métodos ---
Console.WriteLine("--- Métodos (bloques reutilizables) ---");
Console.WriteLine("  Los métodos son bloques de código reutilizables:");
Console.WriteLine("  Se definen con un nombre y se llaman desde cualquier sitio");
Console.WriteLine("  Ejemplo: Console.WriteLine() es un método que ya hemos usado");
Console.WriteLine();

// --- Bloques ---
Console.WriteLine("--- Bloques (conjunto de sentencias entre {}) ---");
{
    int x = 10;
    int y = 20;
    int sumaBloque = x + y;
    Console.WriteLine($"  Dentro del bloque: {x} + {y} = {sumaBloque}");
}
// x, y y sumaBloque ya no existen aquí
Console.WriteLine("  Fuera del bloque: las variables ya no existen");
Console.WriteLine();

// --- using static ---
Console.WriteLine("--- using static (sin escribir Console.) ---");
// Si añadieras: using static System.Console;
// Podrías escribir: WriteLine("Hola") en vez de Console.WriteLine("Hola")
Console.WriteLine("  Con Console.WriteLine → Console.WriteLine(\"Hola\")");
Console.WriteLine("  Sin Console (using static) → WriteLine(\"Hola\")");
Console.WriteLine();

// --- Top-Level Statements ---
Console.WriteLine("--- Top-Level Statements ---");
Console.WriteLine("  Este código está escrito con Top-Level Statements:");
Console.WriteLine("  - Sin class Program");
Console.WriteLine("  - Sin static void Main()");
Console.WriteLine("  - Código directo, limpio y moderno");
Console.WriteLine("  - Introduced en C# 9, recomendado en C# 14");
