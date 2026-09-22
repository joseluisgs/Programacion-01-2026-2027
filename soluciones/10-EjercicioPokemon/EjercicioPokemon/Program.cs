// Pokédex completa — UD01: Introducción a la Programación de Software
// Top-Level Statements, tipos, variables, constantes, operadores,
// conversiones, entrada/salida, interpolación, ternario, ??, ??=

Console.WriteLine("╔══════════════════════════════════════════╗");
Console.WriteLine("║   🎮 POKÉDEX v1.0 — UD01 Programación   ║");
Console.WriteLine("║   Crea tu propia ficha de Pokémon        ║");
Console.WriteLine("╚══════════════════════════════════════════╝");
Console.WriteLine();

// 1. PRESENTACIÓN
Console.Write("¿Cómo te llamas, Entrenador? ");
string? entrenador = Console.ReadLine();
entrenador ??= "Desconocido";
Console.WriteLine($"¡Hola, {entrenador}! Vamos a crear tu ficha Pokémon.\n");

// 2. DATOS DEL POKÉMON
Console.Write("Nombre del Pokémon: ");
string nombre = Console.ReadLine() ?? "Desconocido";

Console.Write("Tipo (Fuego, Agua, Planta, Eléctrico, etc.): ");
string tipo = Console.ReadLine() ?? "Normal";

Console.Write("CP (Combat Power, número entero): ");
int cp = int.TryParse(Console.ReadLine(), out int cpVal) ? cpVal : 0;

Console.Write("Nivel (1-100): ");
int nivel = int.TryParse(Console.ReadLine(), out int nivVal) ? nivVal : 1;
nivel = nivel < 1 ? 1 : nivel > 100 ? 100 : nivel;

Console.Write("¿Es legendario? (s/n): ");
bool esLegendario = Console.ReadLine()?.ToLower() == "s";

Console.Write("Altura en metros (ej: 1.7): ");
double altura = double.TryParse(Console.ReadLine(), out double altVal) ? altVal : 1.0;

Console.WriteLine();

// 3. CÁLCULOS
const double MultiplicadorLegendario = 1.5;

double cpConBonus = cp * MultiplicadorLegendario;
int poderEstimado = cp / 10 + nivel * 2;
string estadoCP = cp >= 1000 ? "MÁXIMO" : cp >= 500 ? "ALTO" : cp >= 200 ? "MEDIO" : "BAJO";
bool esPoderoso = cp >= 500 && nivel >= 20;
string rarity = esLegendario ? "LEGENDARIO" : "COMÚN";
string emojiTipo = tipo == "fuego" ? "🔥"
                 : tipo == "agua" ? "💧"
                 : tipo == "planta" ? "🌿"
                 : tipo == "eléctrico" ? "⚡"
                 : tipo == "dragón" ? "🐉" : "⚪";
int alturaCm = (int)(altura * 100);
string apodo = nombre;

// 4. FICHA
Console.WriteLine("╔══════════════════════════════════════════╗");
Console.WriteLine("║           FICHA DEL POKÉMON              ║");
Console.WriteLine("╠══════════════════════════════════════════╣");
Console.WriteLine($"║  Nombre:      {emojiTipo} {apodo,-28}║");
Console.WriteLine($"║  Tipo:        {tipo,-30}║");
Console.WriteLine($"║  CP:          {cp,-30}║");
Console.WriteLine($"║  Nivel:       {nivel,-30}║");
Console.WriteLine($"║  Altura:      {$"{altura:F2} m ({alturaCm} cm)",-30}║");
Console.WriteLine($"║  Rareza:      {rarity,-30}║");
Console.WriteLine($"║  Estado CP:   {estadoCP,-30}║");
Console.WriteLine($"║  Poder est.:  {poderEstimado,-30}║");
Console.WriteLine($"║  ¿Poderoso?  {(esPoderoso ? "SÍ" : "NO"),-30}║");
Console.WriteLine("╠══════════════════════════════════════════╣");
Console.WriteLine($"║  CP con bonus: {cpConBonus:F1}                        ║");
Console.WriteLine($"║  Entrenador:  {entrenador,-30}║");
Console.WriteLine("╚══════════════════════════════════════════╝\n");

// 5. MENSAJE FINAL
string mensaje = esLegendario
    ? $"¡{entrenador}, capturaste un Pokémon LEGENDARIO! ¡Eres increíble!"
    : esPoderoso
        ? $"¡Buen Pokémon, {entrenador}! Con el tiempo será aún más fuerte."
        : $"{entrenador}, todos los Pokémon son especiales. ¡Sigue entrenando!";

Console.WriteLine(mensaje);
Console.WriteLine("\n¡Like y Suscripción para codificar un montón y nos vemos en el próximo deploy!");
