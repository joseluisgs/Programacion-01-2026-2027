// Ejercicio 49: De Morgan en un Ranking
// Conceptos: operadores lógicos &&, ||, !, Leyes de De Morgan
// Ejecutar: cd EjercicioDeMorgan && dotnet run

Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║   🏅 DE MORGAN EN UN RANKING         ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.WriteLine();

// --- Datos ---
int nivel = 150;
int oro = 5000;

Console.WriteLine("📊 Datos del jugador:");
Console.WriteLine($"  Nivel:  {nivel}");
Console.WriteLine($"  Oro:    {oro:N0}");
Console.WriteLine();

// --- Condición original ---
// "Top 100" si nivel > 200 Y oro > 10000
bool esTop100 = nivel > 200 && oro > 10000;

Console.WriteLine("🔍 Condición original: nivel > 200 && oro > 10000");
Console.WriteLine($"  nivel > 200:  {nivel > 200}");
Console.WriteLine($"  oro > 10000:  {oro > 10000}");
Console.WriteLine($"  Resultado:    {esTop100}");
Console.WriteLine();

// --- De Morgan ---
// !(A && B) == !A || !B
// "NO está en Top 100" = nivel <= 200 OR oro <= 10000
bool noEsTop100 = !(nivel > 200 && oro > 10000);
bool noEsTop100_DeMorgan = nivel <= 200 || oro <= 10000;

Console.WriteLine("🔄 Ley de De Morgan: !(A && B) = !A || !B");
Console.WriteLine($"  !(nivel > 200 && oro > 10000):     {noEsTop100}");
Console.WriteLine($"  nivel <= 200 || oro <= 10000:       {noEsTop100_DeMorgan}");
Console.WriteLine($"  ¿Son iguales? {noEsTop100 == noEsTop100_DeMorgan} ✅");
Console.WriteLine();

// --- Resultado ---
string mensaje = esTop100
    ? "🏆 ¡Estás en el Top 100!"
    : $"No estás en Top 100. Necesitas: nivel > 200 (tienes {nivel}) Y oro > 10.000 (tienes {oro:N0})";

Console.WriteLine($"  {mensaje}");
Console.WriteLine();

// --- Ejemplo 2: De Morgan con OR ---
Console.WriteLine("══════════════════════════════════════");
Console.WriteLine();

bool reportado = false;
bool advertido = true;

// "Baneado" si reportado OR advertido
bool baneado = reportado || advertido;

// !(A || B) = !A && !B
bool noBaneado = !(reportado || advertido);
bool noBaneado_DeMorgan = !reportado && !advertido;

Console.WriteLine("📊 Ejemplo 2: Sistema de baneos");
Console.WriteLine($"  reportado:  {reportado}");
Console.WriteLine($"  advertido:  {advertido}");
Console.WriteLine($"  Baneado (reportado || advertido):      {baneado}");
Console.WriteLine($"  !(reportado || advertido):             {noBaneado}");
Console.WriteLine($"  !reportado && !advertido:              {noBaneado_DeMorgan}");
Console.WriteLine($"  ¿Son iguales? {noBaneado == noBaneado_DeMorgan} ✅");
