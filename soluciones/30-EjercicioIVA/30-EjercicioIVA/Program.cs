// Ejercicio 23: Precio con IVA de una Skin
// Conceptos: decimal, const, operadores aritméticos, interpolación
// Ejecutar: cd 30-EjercicioIVA && dotnet run

Console.WriteLine("=== EJERCICIO 23: PRECIO CON IVA ===");
Console.WriteLine();

// Constante
const double IVA = 0.21;

// Datos
// string nombreSkin = "Espada Legendaria";
// double precioBase = 19.99;
Console.Write("Nombre de la skin: ");
var nombreSkin = Console.ReadLine() ?? "Skin Desconocida";

Console.Write("Precio base: ");
var precioBaseInput = Console.ReadLine() ?? "0";
var precioBase = decimal.TryParse(precioBaseInput, out decimal pb) ? pb : decimal.MinValue;


// Cálculos
decimal iva = precioBase * (decimal)IVA;
decimal precioFinal = precioBase + iva;

// Salida
Console.WriteLine($"  Skin:        {nombreSkin}");
Console.WriteLine($"  Precio base: {precioBase:F2}€");
Console.WriteLine($"  IVA (21%):   {iva:F2}€");
Console.WriteLine($"  ─────────────────────────");
Console.WriteLine($"  Total:       {precioFinal:F2}€");
