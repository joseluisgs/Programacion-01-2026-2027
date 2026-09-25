// Ejercicio 35: Precio Seguro desde Input
// Conceptos: decimal.TryParse, ??, ternario, entrada validada
// Ejecutar: dotnet run ej35.cs

Console.WriteLine("=== PRECIO SEGURO DESDE INPUT ===");
Console.WriteLine();

Console.Write("Introduce el precio de una compra (€): ");
string input = Console.ReadLine() ?? "";

// TryParse: convierte sin excepción
bool esValido = decimal.TryParse(input, out decimal precio);

// Ternario para el resultado
string resultado = esValido
    ? $"✅ Compra registrada: {precio:F2}€"
    : $"❌ Error: \"{input}\" no es un precio válido";

Console.WriteLine(resultado);

// Cálculos con ternario
const double IVA = 0.21;
double iva = (double)precio * IVA;
double totalConIva = (double)precio + iva;

string desglose = esValido
    ? $"\n  Precio base:  {precio:F2}€\n  IVA (21%):    {iva:F2}€\n  Total:        {totalConIva:F2}€"
    : "";
Console.WriteLine(desglose);
