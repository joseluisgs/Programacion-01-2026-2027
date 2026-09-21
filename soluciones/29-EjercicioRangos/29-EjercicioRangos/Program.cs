// Ejercicio 16: Rangos de un Videojuego Competitivo
// Conceptos: enum con valores asignados, conversión a int, ternario
// Ejecutar: cd 29-EjercicioRangos && dotnet run

Console.WriteLine("=== EJERCICIO 16: RANGOS DE VIDEOJUEGO ===");
Console.WriteLine();

Rango miRango = Rango.Oro;
Console.WriteLine($"  Mi rango: {miRango}");
Console.WriteLine($"  Valor numérico: {(int)miRango}");
Console.WriteLine();

// Todos los rangos
Console.WriteLine("--- Todos los rangos ---");
Console.WriteLine($"  Bronce   = {(int)Rango.Bronce}");
Console.WriteLine($"  Plata    = {(int)Rango.Plata}");
Console.WriteLine($"  Oro      = {(int)Rango.Oro}");
Console.WriteLine($"  Platino  = {(int)Rango.Platino}");
Console.WriteLine($"  Diamante = {(int)Rango.Diamante}");
Console.WriteLine($"  Leyenda  = {(int)Rango.Leyenda}");
Console.WriteLine();

// Comparar rangos
Console.WriteLine("--- Comparar rangos ---");
string msg = miRango == Rango.Leyenda ? "¡Eres el mejor!"
           : miRango == Rango.Diamante ? "Casi en la cima"
           : miRango == Rango.Platino ? "Muy buen rango"
           : miRango == Rango.Oro ? "Buen rango, sigue así"
           : "Sigue subiendo";
Console.WriteLine($"  {miRango}: {msg}");

// Enum: va al final en Top-Level Statements
enum Rango { Bronce = 1, Plata = 2, Oro = 3, Platino = 4, Diamante = 5, Leyenda = 6 }
