// Ejercicio 22: Temperature Check para eSports
// Conceptos: decimal.TryParse, ternario anidado, operadores relacionales y lógicos
// Ejecutar: dotnet run ej22.cs

Console.WriteLine("=== TEMPERATURE CHECK — eSPORTS ===");
Console.WriteLine();

Console.Write("Temperatura del servidor (°C): ");
string input = Console.ReadLine() ?? "0";
decimal temperatura = decimal.TryParse(input, out decimal t) ? t : decimal.MinValue;

Console.WriteLine();

// Ternario anidado para la clasificación
string estado = 
temperatura == decimal.MinValue ? $"❌ Entrada no válida\n  Por favor, introduce una temperatura válida."
              : temperatura < 30 ? $"🟢 Servidor OK ({temperatura}°C)\n  Todo funciona correctamente."
              : temperatura < 50 ? $"🟡 Advertencia: temperatura alta ({temperatura}°C)\n  Considera ventilación adicional."
              : $"🔴 CRÍTICO: servidor sobrecalentado ({temperatura}°C)\n  ¡Apaga el servidor inmediatamente!";
Console.WriteLine(estado);
