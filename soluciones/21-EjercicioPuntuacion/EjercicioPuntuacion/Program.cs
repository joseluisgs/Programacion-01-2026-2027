// Ejercicio 44: Puntuación Vacía (Nullable)
// Conceptos: int?, ??, par o impar, nullable
// Ejecutar: cd EjercicioPuntuacion && dotnet run

Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║   🏆 PUNTUACIÓN DE JUGADOR          ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.WriteLine();

// --- Variable nullable ---
int? puntuacion = null;

// --- Mostrar estado con ?? ---
int puntos = puntuacion ?? 0;
string estado = puntuacion.HasValue ? "Puntuación registrada" : "Sin puntuación aún";

Console.WriteLine($"  Puntuación: {puntuacion?.ToString() ?? "null"}");
Console.WriteLine($"  Estado:     {estado}");
Console.WriteLine($"  Puntos:     {puntos}");
Console.WriteLine();

// --- Simular que el jugador juega ---
Console.WriteLine("Simulando partida...");
puntuacion = 2847;

puntos = puntuacion ?? 0;
estado = puntuacion.HasValue ? "Puntuación registrada" : "Sin puntuación aún";

Console.WriteLine($"  Puntuación: {puntuacion}");
Console.WriteLine($"  Estado:     {estado}");
Console.WriteLine($"  Puntos:     {puntos}");
Console.WriteLine();

// --- Par o impar ---
string parImpar = puntos % 2 == 0 ? "PAR" : "IMPAR";
Console.WriteLine($"  {puntos} es {parImpar} ({puntos} % 2 = {puntos % 2})");
Console.WriteLine();

// --- Clasificación ---
string rango = puntos >= 5000 ? "🏆 Leyenda"
             : puntos >= 3000 ? "🥇 Oro"
             : puntos >= 1000 ? "🥈 Plata"
             : puntos >= 100 ? "🥉 Bronce"
             : "Sin rango";

Console.WriteLine($"  Rango: {rango}");
