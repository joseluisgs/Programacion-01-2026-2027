// Nota Media de un Módulo
// Conceptos: const, double.TryParse, operador *, suma acumulada, ternario
// Ejecutar: dotnet run ej48.cs

Console.WriteLine("=== NOTA MEDIA DE UN MÓDULO ===");
Console.WriteLine();

const double PESO_TEORIA = 0.40;
const double PESO_PRACTICA = 0.60;

Console.Write("Nota de teoría (0-10): ");
string teoriaInput = Console.ReadLine() ?? "0";
double notaTeoria = double.TryParse(teoriaInput, out double t) ? t : 0;

Console.Write("Nota de práctica (0-10): ");
string practicaInput = Console.ReadLine() ?? "0";
double notaPractica = double.TryParse(practicaInput, out double p) ? p : 0;

Console.WriteLine();

// Cálculo de nota media ponderada
double notaMedia = (notaTeoria * PESO_TEORIA) + (notaPractica * PESO_PRACTICA);
bool aprobado = notaMedia >= 5;

Console.WriteLine($"📚 Teoría:   {notaTeoria:F1} × {PESO_TEORIA:P0} = {notaTeoria * PESO_TEORIA:F2}");
Console.WriteLine($"💻 Práctica: {notaPractica:F1} × {PESO_PRACTICA:P0} = {notaPractica * PESO_PRACTICA:F2}");
Console.WriteLine($"  ─────────────────────────────────");
Console.WriteLine($"  Nota media: {notaMedia:F2}");
Console.WriteLine();

// Resultado con ternario
string resultado = aprobado ? "✅ APROBADO" : "❌ SUSPENSO";
Console.WriteLine($"  Resultado: {resultado}");
