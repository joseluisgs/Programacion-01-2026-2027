// Ejercicio 28: División de Botín entre Jugadores
// Conceptos: división entera /, módulo %, int
// Ejecutar: dotnet run ej28.cs

Console.WriteLine("=== DIVISIÓN DE BOTÍN ENTRE JUGADORES ===");
Console.WriteLine();

int monedasTotales = 1550;
int jugadores = 4;

// División entera: cuántas monedas por jugador
int monedasPorJugador = monedasTotales / jugadores;

// Módulo: cuántas sobran
int sobran = monedasTotales % jugadores;

Console.WriteLine($"  Monedas totales: {monedasTotales}");
Console.WriteLine($"  Jugadores:       {jugadores}");
Console.WriteLine($"  ─────────────────────────────");
Console.WriteLine($"  División:        {monedasTotales} / {jugadores} = {monedasPorJugador}");
Console.WriteLine($"  Módulo:          {monedasTotales} % {jugadores} = {sobran}");
Console.WriteLine($"  ─────────────────────────────");
Console.WriteLine($"  Cada jugador recibe: 🪙 {monedasPorJugador} monedas");
Console.WriteLine($"  Sobran:              🪙 {sobran} monedas");
Console.WriteLine();

// Verificación
int totalRepartido = monedasPorJugador * jugadores + sobran;
Console.WriteLine($"  Verificación: {monedasPorJugador} × {jugadores} + {sobran} = {totalRepartido} ✅");
