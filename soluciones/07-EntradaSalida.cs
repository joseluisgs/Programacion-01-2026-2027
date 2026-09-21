// 06-EntradaSalida.cs
// Ejemplo: Entrada y salida de datos — WriteLine, Write, ReadLine, interpolación.
// Ejecutar: dotnet run 06-EntradaSalida.cs
//
// NOTA: Este script pide datos por teclado.
// Si lo ejecutas con dotnet run, introduce los datos cuando se pida.

Console.WriteLine("=== ENTRADA Y SALIDA DE DATOS ===");
Console.WriteLine();

// --- Salida ---
Console.WriteLine("--- Salida con WriteLine (salta de línea) ---");
Console.WriteLine("Primera línea");
Console.WriteLine("Segunda línea");
Console.WriteLine();

Console.WriteLine("--- Salida con Write (sin salto) ---");
Console.Write("Escribe ");
Console.Write("sin ");
Console.Write("saltar ");
Console.WriteLine("(salto manual)");
Console.WriteLine();

// --- Interpolación ---
Console.WriteLine("--- Interpolación de strings ---");
string nombre = "Ana";
int edad = 25;
double precio = 19.99;

Console.WriteLine($"  Hola, {nombre}");
Console.WriteLine($"  Tengo {edad} años");
Console.WriteLine($"  Precio: {precio}€");
Console.WriteLine($"  Mañana tendré {edad + 1} años");
Console.WriteLine($"  Precio con 2 decimales: {precio:F2}€");
Console.WriteLine($"  Porcentaje: {0.85:P0}");
Console.WriteLine($"  Número con separadores: {1000000:N0}");
Console.WriteLine();

// --- Concatenación (forma antigua) ---
Console.WriteLine("--- Concatenación (menos recomendada) ---");
string msg1 = "Hola " + nombre + ", tienes " + edad + " años";
string msg2 = $"Hola {nombre}, tienes {edad} años";
Console.WriteLine($"  Concatenación: {msg1}");
Console.WriteLine($"  Interpolación: {msg2}");
Console.WriteLine();

// --- Entrada de datos ---
Console.WriteLine("--- Entrada de datos ---");
Console.Write("¿Cómo te llamas? ");
string nombreUsuario = Console.ReadLine() ?? "Desconocido";
Console.WriteLine($"  Hola, {nombreUsuario}!");
Console.WriteLine();

Console.Write("¿Cuántos años tienes? ");
string textoEdad = Console.ReadLine() ?? "0";
int edadUsuario = int.TryParse(textoEdad, out int e) ? e : 0;
Console.WriteLine($"  Tienes {edadUsuario} años");
Console.WriteLine();

// --- ReadKey ---
Console.WriteLine("--- Console.ReadKey ---");
Console.Write("Pulsa cualquier tecla para continuar...");
Console.ReadKey();
Console.WriteLine();
Console.WriteLine("  ¡Continuamos!");
Console.WriteLine();

// --- Environment.NewLine ---
Console.WriteLine("--- Environment.NewLine ---");
string multilinea = "Línea 1" + Environment.NewLine + "Línea 2";
Console.WriteLine(multilinea);
Console.WriteLine($"  (En Windows: \\r\\En Linux: \\n)");
