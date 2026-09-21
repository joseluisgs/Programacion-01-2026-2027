// Ejercicio 24: Resumen de Compra en Steam
// Top-Level Statements, entrada/salida, TryParse, operadores, ternario
// Ejecutar: cd EjercicioSteam && dotnet run

Console.OutputEncoding = System.Text.Encoding.UTF8;

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
bool datosValidos = precio > 0 && cantidad > 0;
string mensajeValidacion = datosValidos ? "" : "❌ Datos no válidos. Introduce valores positivos.";
Console.WriteLine(mensajeValidacion);

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

decimal falta = UMBRAL_DESCUENTO - subtotal;
string msgDescuento = aplicarDescuento
    ? $"  Descuento:     -{descuento:F2} € ({DESCUENTO_PORCENTAJE:P0})\n  (¡Superas los {UMBRAL_DESCUENTO}€, tienes 10% off!)"
    : $"  Descuento:     0.00 €\n  (Te faltan {falta:F2}€ para el 10% de descuento)";
Console.WriteLine(msgDescuento);

Console.WriteLine($"  ════════════════════════════════════");
Console.WriteLine($"  TOTAL:         {total:F2} €");
Console.WriteLine("══════════════════════════════════════");
Console.WriteLine();

// Mensaje con ternario
string mensaje = aplicarDescuento
    ? $"¡Excelente compra! Ahorras {descuento:F2}€ con el descuento."
    : $"Compra normal. Si gastas más de {UMBRAL_DESCUENTO}€, obtienes 10% de descuento.";
Console.WriteLine(mensaje);
