// Ejercicio 19: Calculadora de IMC
// Conceptos: double.TryParse, operadores aritméticos, ternario anidado
// Ejecutar: dotnet run ej19.cs

Console.WriteLine("=== CALCULADORA DE IMC ===");
Console.WriteLine();

Console.Write("Peso en kg (ej: 70.5): ");
string pesoInput = Console.ReadLine() ?? "0";
double peso = double.TryParse(pesoInput, out double p) ? p : 0;

Console.Write("Altura en metros (ej: 1.75): ");
string alturaInput = Console.ReadLine() ?? "0";
double altura = double.TryParse(alturaInput, out double a) ? a : 0;

Console.WriteLine();

double imc = peso / (altura * altura);

// Ternario anidado para la clasificación
string clasificacion = altura == 0 ? "No válido"
                     : imc < 18.5 ? "Bajo peso"
                     : imc < 25.0 ? "Normal"
                     : imc < 30.0 ? "Sobrepeso"
                     : "Obesidad";

string emoji = altura == 0 ? "❌"
             : imc < 18.5 ? "🔵"
             : imc < 25.0 ? "🟢"
             : imc < 30.0 ? "🟡"
             : "🔴";

var imcFormatted = altura == 0 ? "No calculado" : imc.ToString("F2");

Console.WriteLine($"Tu IMC es: {imcFormatted}");
Console.WriteLine($"Clasificación: {emoji} {clasificacion}");
Console.WriteLine();

Console.WriteLine("Tabla de referencia:");
Console.WriteLine("  🔵 Bajo peso:   < 18.5");
Console.WriteLine("  🟢 Normal:      18.5 - 24.9");
Console.WriteLine("  🟡 Sobrepeso:   25.0 - 29.9");
Console.WriteLine("  🔴 Obesidad:    ≥ 30.0");
Console.WriteLine("  ❌ No válido:    Entrada no numérica o altura = 0");
