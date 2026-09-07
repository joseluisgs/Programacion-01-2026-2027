// Ejercicio 24: Resumen de Compra en Steam
// Top-Level Statements, entrada/salida, TryParse, operadores, ternario
// Ejecutar: cd EjercicioSteam && dotnet run

Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║   🎮 RESUMEN DE COMPRA — STEAM      ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.WriteLine();

// --- Entrada de datos ---
Console.Write("Precio de un juego (€): ");
string precioInput = Console.ReadLine() ?? "0";
decimal precio = decimal.TryParse(precioInput, out decimal p) ? p : 0;

Console.Write("Cantidad de juegos: ");
string cantidadInput = Console.ReadLine() ?? "0";
int cantidad = int.TryParse(cantidadInput, out int c) ? c : 0;

Console.WriteLine();

// --- Validación ---
if (precio <= 0 || cantidad <= 0)
{
    Console.WriteLine("❌ Datos no válidos. Introduce valores positivos.");
    return;
}

// --- Cálculos con operadores ---
decimal subtotal = precio * cantidad;

// Constante
const decimal DESCUENTO_PORCENTAJE = 0.10m;  // 10%
const decimal UMBRAL_DESCUENTO = 50m;

// Operador relacional + lógico + ternario
bool aplicarDescuento = subtotal > UMBRAL_DESCUENTO;
decimal descuento = aplicarDescuento ? subtotal * DESCUENTO_PORCENTAJE : 0;
decimal total = subtotal - descuento;

// --- Salida con interpolación ---
Console.WriteLine("══════════════════════════════════════");
Console.WriteLine($"  Juego:         {precio:F2} €");
Console.WriteLine($"  Cantidad:      {cantidad}");
Console.WriteLine($"  ──────────────────────────────────");
Console.WriteLine($"  Subtotal:      {subtotal:F2} €");

if (aplicarDescuento)
{
    Console.WriteLine($"  Descuento:     -{descuento:F2} € ({DESCUENTO_PORCENTAJE:P0})");
    Console.WriteLine($"  (¡Superas los {UMBRAL_DESCUENTO}€, tienes 10% off!)");
}
else
{
    decimal falta = UMBRAL_DESCUENTO - subtotal;
    Console.WriteLine($"  Descuento:     0.00 €");
    Console.WriteLine($"  (Te faltan {falta:F2}€ para el 10% de descuento)");
}

Console.WriteLine($"  ════════════════════════════════════");
Console.WriteLine($"  TOTAL:         {total:F2} €");
Console.WriteLine("══════════════════════════════════════");
Console.WriteLine();

// Mensaje con ternario
string mensaje = aplicarDescuento
    ? $"¡Excelente compra! Ahorras {descuento:F2}€ con el descuento."
    : $"Compra normal. Si gastas más de {UMBRAL_DESCUENTO}€, obtienes 10% off.";
Console.WriteLine(mensaje);
