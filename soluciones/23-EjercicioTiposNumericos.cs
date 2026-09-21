// Ejercicio 8: Conociendo los Tipos Numéricos
// Conceptos: tipos numéricos, MinValue, MaxValue, sizeof
// Ejecutar: dotnet run ej08.cs

Console.WriteLine("=== TIPOS NUMÉRICOS DE C# ===");
Console.WriteLine();

Console.WriteLine("┌──────────┬────────┬──────────────────────────────────────┐");
Console.WriteLine("│ Tipo     │ Bytes  │ Rango                               │");
Console.WriteLine("├──────────┼────────┼──────────────────────────────────────┤");

Console.WriteLine($"│ sbyte    │ {sizeof(sbyte),-6} │ {sbyte.MinValue,-36} │");
Console.WriteLine($"│ byte     │ {sizeof(byte),-6} │ {byte.MinValue,-20} a {byte.MaxValue,-14} │");
Console.WriteLine($"│ short    │ {sizeof(short),-6} │ {short.MinValue,-20} a {short.MaxValue,-14} │");
Console.WriteLine($"│ ushort   │ {sizeof(ushort),-6} │ {ushort.MinValue,-20} a {ushort.MaxValue,-14} │");
Console.WriteLine($"│ int      │ {sizeof(int),-6} │ {int.MinValue,-20} a {int.MaxValue,-14} │");
Console.WriteLine($"│ uint     │ {sizeof(uint),-6} │ {uint.MinValue,-20} a {uint.MaxValue,-14} │");
Console.WriteLine($"│ long     │ {sizeof(long),-6} │ {long.MinValue} │");
Console.WriteLine($"│ ulong    │ {sizeof(ulong),-6} │ {ulong.MinValue} │");

Console.WriteLine("├──────────┼────────┼──────────────────────────────────────┤");

Console.WriteLine($"│ float    │ {sizeof(float),-6} │ ~{float.MinValue:E2} a ~{float.MaxValue:E2} │");
Console.WriteLine($"│ double   │ {sizeof(double),-6} │ ~{double.MinValue:E2} a ~{double.MaxValue:E2} │");
Console.WriteLine($"│ decimal  │ {sizeof(decimal),-6} │ ~{decimal.MinValue:E2} │");

Console.WriteLine("└──────────┴────────┴──────────────────────────────────────┘");
Console.WriteLine();

Console.WriteLine("💡 Usa int por defecto para enteros.");
Console.WriteLine("💡 Usa decimal para dinero (máxima precisión).");
Console.WriteLine("💡 Usa double para cálculos científicos.");
