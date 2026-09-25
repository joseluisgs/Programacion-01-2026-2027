// Ejercicio 41: Precedencia Lógica en un IF
// Conceptos: &&, ||, !, precedencia de operadores lógicos
// Ejecutar: dotnet run ej41.cs

Console.WriteLine("=== PRECEDENCIA LÓGICA ===");
Console.WriteLine();

bool c1 = true;
bool c2 = false;
bool c3 = true;

Console.WriteLine($"  c1 = {c1}");
Console.WriteLine($"  c2 = {c2}");
Console.WriteLine($"  c3 = {c3}");
Console.WriteLine();

// Expresión: !c1 || c2 && c3
// Precedencia: ! > && > ||
// Primero: !c1 = false
// Luego: c2 && c3 = false && true = false
// Final: false || false = false
bool resultado = !c1 || c2 && c3;

Console.WriteLine("  Expresión: !c1 || c2 && c3");
Console.WriteLine();
Console.WriteLine("  Orden de precedencia:");
Console.WriteLine("    1. !c1       = !" + c1 + " = " + !c1);
Console.WriteLine("    2. c2 && c3  = " + c2 + " && " + c3 + " = " + (c2 && c3));
Console.WriteLine("    3. resultado = " + !c1 + " || " + (c2 && c3) + " = " + resultado);
Console.WriteLine();
Console.WriteLine($"  Resultado: {resultado}");
Console.WriteLine();

// Sin precedencia (con paréntesis explícitos)
bool resultadoExplicito = (!c1) || (c2 && c3);
Console.WriteLine($"  Con paréntesis explícitos: (!c1) || (c2 && c3) = {resultadoExplicito}");
Console.WriteLine($"  ¿Mismo resultado? {resultado == resultadoExplicito} ✅");
