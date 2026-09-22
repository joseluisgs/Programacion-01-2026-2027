// Ejercicio 26: XP y Subida de Nivel
// Conceptos: +=, *=, +=, división entera, módulo
// Ejecutar: dotnet run ej26.cs

Console.WriteLine("=== XP Y SUBIDA DE NIVEL ===");
Console.WriteLine();

int xpActual = 0;
int xpPorNivel = 1000;

Console.WriteLine($"XP inicial: {xpActual}");
Console.WriteLine();

// Ganar 250 XP
xpActual += 250;
Console.WriteLine($"Ganas 250 XP → xpActual = {xpActual}");
Console.WriteLine($"  Nivel: {xpActual / xpPorNivel} (XP: {xpActual % xpPorNivel}/{xpPorNivel})");

// Ganar el doble
xpActual *= 2;
Console.WriteLine($"Ganas el doble (×2) → xpActual = {xpActual}");
Console.WriteLine($"  Nivel: {xpActual / xpPorNivel} (XP: {xpActual % xpPorNivel}/{xpPorNivel})");

// Ganar 100 más
xpActual += 100;
Console.WriteLine($"Ganas 100 más → xpActual = {xpActual}");
Console.WriteLine($"  Nivel: {xpActual / xpPorNivel} (XP: {xpActual % xpPorNivel}/{xpPorNivel})");

Console.WriteLine();
Console.WriteLine("═══════════════════════════════════");

int nivel = xpActual / xpPorNivel;
int xpSiguienteNivel = xpPorNivel - (xpActual % xpPorNivel);

Console.WriteLine($"📊 RESUMEN:");
Console.WriteLine($"  XP total:     {xpActual}");
Console.WriteLine($"  Nivel actual: {nivel}");
Console.WriteLine($"  XP para subir: {xpSiguienteNivel}");
Console.WriteLine($"  Barra:        [{new string('█', Math.Min(xpActual % xpPorNivel / 100, 10))}{new string('░', 10 - Math.Min(xpActual % xpPorNivel / 100, 10))}]");
