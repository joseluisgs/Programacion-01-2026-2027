// Ejercicio 47: Validación de Partida
// Top-Level Statements, operadores lógicos, constantes, ternario
// Ejecutar: cd EjercicioValidacion && dotnet run

Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║   🎮 VALIDACIÓN DE PARTIDA ONLINE   ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.WriteLine();

// --- Constantes del servidor ---
const double PING_MAXIMO = 100.0;
const int JUGADORES_MINIMOS = 2;
const int JUGADORES_MAXIMOS = 10;
const double PING_ADVERTENCIA = 50.0;

// --- Datos de la partida ---
double ping = 45.0;
int jugadores = 8;
bool servidorActivo = true;

// Mostrar estado actual
Console.WriteLine("📊 Estado de la partida:");
Console.WriteLine($"  Ping:           {ping} ms");
Console.WriteLine($"  Jugadores:      {jugadores}/{JUGADORES_MAXIMOS}");
Console.WriteLine($"  Servidor activo: {servidorActivo}");
Console.WriteLine();

// --- Validación con operadores lógicos ---
// Una partida es "válida" si:
//   - ping < 100 Y
//   - jugadores >= 2 Y
//   - servidorActivo es true
bool partidaValida = ping < PING_MAXIMO
                  && jugadores >= JUGADORES_MINIMOS
                  && servidorActivo;

// Ternario para el resultado
string estado = partidaValida ? "✅ VÁLIDA" : "❌ NO VÁLIDA";

Console.WriteLine("🔍 Validación:");
Console.WriteLine($"  ping < {PING_MAXIMO}: {ping < PING_MAXIMO}");
Console.WriteLine($"  jugadores >= {JUGADORES_MINIMOS}: {jugadores >= JUGADORES_MINIMOS}");
Console.WriteLine($"  servidorActivo: {servidorActivo}");
Console.WriteLine($"  ──────────────────────────────────");
Console.WriteLine($"  Resultado: {estado}");
Console.WriteLine();

// --- Más validaciones ---
Console.WriteLine("📋 Validaciones adicionales:");

// ¿Hay buen ping?
bool buenPing = ping < PING_ADVERTENCIA;
Console.WriteLine($"  ¿Buen ping (< {PING_ADVERTENCIA}ms)? {(buenPing ? "SÍ 🟢" : "NO 🟡")}");

// ¿Suficientes jugadores?
bool suficientesJugadores = jugadores >= JUGADORES_MINIMOS;
Console.WriteLine($"  ¿Suficientes jugadores (≥ {JUGADORES_MINIMOS})? {(suficientesJugadores ? "SÍ 🟢" : "NO 🔴")}");

// ¿Llena?
bool partidaLlena = jugadores >= JUGADORES_MAXIMOS;
Console.WriteLine($"  ¿Partida llena (≥ {JUGADORES_MAXIMOS})? {(partidaLlena ? "SÍ 🔴" : "NO 🟢")}");

Console.WriteLine();

// --- Resumen final ---
Console.WriteLine("══════════════════════════════════════");
string resumen = !servidorActivo ? "❌ Servidor caído"
               : ping >= PING_MAXIMO ? "❌ Ping demasiado alto"
               : jugadores < JUGADORES_MINIMOS ? "❌ No hay suficientes jugadores"
               : partidaLlena ? "🟡 Partida llena"
               : "✅ Todo listo para jugar";

Console.WriteLine($"  {resumen}");
Console.WriteLine("══════════════════════════════════════");
