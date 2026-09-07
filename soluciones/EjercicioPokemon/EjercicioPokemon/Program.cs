// Ejercicio Pokémon — UD01: Introducción a la Programación de Software
// Top-Level Statements: código directo sin class ni Main
// Conceptos aplicados: tipos de datos, variables, constantes, operadores,
// conversiones, entrada/salida, interpolación, ternario, ?. y ??

// ============================================================
// 1. PRESENTACIÓN
// ============================================================
Console.WriteLine("╔══════════════════════════════════════════╗");
Console.WriteLine("║   🎮 POKÉDEX v1.0 — UD01 Programación   ║");
Console.WriteLine("║   Crea tu propia ficha de Pokémon        ║");
Console.WriteLine("╚══════════════════════════════════════════╝");
Console.WriteLine();

Console.Write("¿Cómo te llamas, Entrenador? ");
string? entrenador = Console.ReadLine();
// ?? "Desconocido" → si el usuario no escribe nada, usa "Desconocido"
entrenador ??= "Desconocido";

Console.Write($"¡Hola, {entrenador}! Vamos a crear tu ficha Pokémon.\n");
Console.WriteLine();

// ============================================================
// 2. DATOS DEL POKÉMON (entrada de datos)
// ============================================================
Console.Write("Nombre del Pokémon: ");
string nombre = Console.ReadLine() ?? "Desconocido";

Console.Write("Tipo (Fuego, Agua, Planta, Eléctrico, etc.): ");
string tipo = Console.ReadLine() ?? "Normal";

Console.Write("CP (Combat Power, número entero): ");
string cpInput = Console.ReadLine() ?? "0";
// TryParse: convierte sin excepción. Si falla, usa 0.
int cp = int.TryParse(cpInput, out int cpValido) ? cpValido : 0;

Console.Write("Nivel (1-100): ");
string nivelInput = Console.ReadLine() ?? "1";
int nivel = int.TryParse(nivelInput, out int nivelValido) ? nivelValido : 1;
// Clamp: limitar entre 1 y 100
nivel = nivel < 1 ? 1 : nivel > 100 ? 100 : nivel;

Console.Write("¿Es legendario? (s/n): ");
string legendarioInput = Console.ReadLine()?.ToLower() ?? "n";
// Ternario: si es "s" → true, si no → false
bool esLegendario = legendarioInput == "s";

Console.Write("Altura en metros (ej: 1.7): ");
string alturaInput = Console.ReadLine() ?? "1.0";
double altura = double.TryParse(alturaInput, out double alturaValida) ? alturaValida : 1.0;

Console.WriteLine();

// ============================================================
// 3. CÁLCULOS (operadores y conversiones)
// ============================================================

// Constantes
const double MultiplicadorLegendario = 1.5;

// Operadores aritméticos
double cpConBonus = cp * MultiplicadorLegendario;
int poderEstimado = cp / 10 + nivel * 2;

// Operador ternario: ¿está en rango?
string estadoCP = cp >= 1000 ? "MÁXIMO" : cp >= 500 ? "ALTO" : cp >= 200 ? "MEDIO" : "BAJO";

// Operador relacional + lógico
bool esPoderoso = cp >= 500 && nivel >= 20;

// Asignación condicional ??
string rarity = esLegendario ? "LEGENDARIO" : "COMÚN";
string emojiTipo = tipo.ToLower() switch
{
    "fuego" => "🔥",
    "agua" => "💧",
    "planta" => "🌿",
    "eléctrico" => "⚡",
    "dragón" => "🐉",
    "normal" => "⚪",
    _ => "❓"
};

// Conversión: double a int (truncando)
int alturaCm = (int)(altura * 100);

// Coalescencia
string apodo = nombre.Length > 10 ? nombre[..10] + "..." : nombre;

// ============================================================
// 4. FICHA DEL POKÉMON (salida de datos)
// ============================================================
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

// Interpolación con formato
Console.WriteLine($"║  CP con bonus legendario: {cpConBonus:F1}         ║");
Console.WriteLine($"║  Entrenador: {entrenador,-33}║");
Console.WriteLine("╚══════════════════════════════════════════╝");

// ============================================================
// 5. MENSAJE FINAL
// ============================================================
Console.WriteLine();

// Ternario anidado
string mensaje = esLegendario
    ? $"¡{entrenador}, capturaste un Pokémon LEGENDARIO! ¡Eres increíble!"
    : esPoderoso
        ? $"¡Buen Pokémon, {entrenador}! Con el tiempo será aún más fuerte."
        : $"{entrenador}, todos los Pokémon son especiales. ¡Sigue entrenando!";

Console.WriteLine(mensaje);
Console.WriteLine();
Console.WriteLine("Gracias por usar la Pokédex v1.0");
Console.WriteLine("¡Like y Suscripción para codificar un montón y nos vemos en el próximo deploy!");
