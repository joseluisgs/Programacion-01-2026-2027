// Ejercicio 20: Conversor de Monedas de Videojuego
// Conceptos: int.TryParse, división entera /, módulo %, const
// Ejecutar: cd EjercicioMonedas && dotnet run

Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║   💰 CONVERSOR DE MONEDAS            ║");
Console.WriteLine("║   1000 oros = 1 diamante             ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.WriteLine();

// --- Constantes ---
const int OROS_POR_DIAMANTE = 1000;

// --- Entrada ---
Console.Write("¿Cuántos oros tienes? ");
string input = Console.ReadLine() ?? "0";
int oros = int.TryParse(input, out int o) ? o : 0;

Console.WriteLine();

// --- Cálculos con operadores ---
int diamantes = oros / OROS_POR_DIAMANTE;  // División entera
int orosSobran = oros % OROS_POR_DIAMANTE; // Módulo (resto)

// --- Salida ---
Console.WriteLine("══════════════════════════════════════");
Console.WriteLine($"  Tus oros:          {oros:N0}");
Console.WriteLine($"  División:          {oros} / {OROS_POR_DIAMANTE} = {diamantes}");
Console.WriteLine($"  Módulo:            {oros} % {OROS_POR_DIAMANTE} = {orosSobran}");
Console.WriteLine($"  ──────────────────────────────────");
Console.WriteLine($"  Diamantes:         💎 {diamantes}");
Console.WriteLine($"  Oros sobrantes:    🪙 {orosSobran}");
Console.WriteLine("══════════════════════════════════════");

string msgDiamantes = diamantes > 0 ? $"\n  ¡Enhorabuena! Has obtenido {diamantes} diamante(s)." : "";
Console.WriteLine(msgDiamantes);

string msgSobrantes = orosSobran > 0
    ? $"  Te quedan {orosSobran} oros sin convertir.\n  Necesitas {OROS_POR_DIAMANTE - orosSobran} oros más para otro diamante."
    : "";
Console.WriteLine(msgSobrantes);
