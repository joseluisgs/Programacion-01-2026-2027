// Ejercicio 48: Tupla de Estadísticas
// Conceptos: tupla, desestructuración, Item1/Item2/Item3, descarte _
// Ejecutar: cd 26-EjercicioTuplaJugador && dotnet run

Console.WriteLine("=== EJERCICIO 48: TUPLA JUGADOR ===");
Console.WriteLine();

// --- Tupla con nombres ---
Console.WriteLine("--- Tupla con nombres ---");
(string nombre, int nivel, int puntos) jugador = ("Ana", 25, 1500);
Console.WriteLine($"  nombre = {jugador.nombre}");
Console.WriteLine($"  nivel  = {jugador.nivel}");
Console.WriteLine($"  puntos = {jugador.puntos}");
Console.WriteLine();

// --- Acceso con Item1, Item2, Item3 ---
Console.WriteLine("--- Acceso con Item1/Item2/Item3 ---");
var datos = ("Carlos", 42, 9800);
Console.WriteLine($"  Item1 = {datos.Item1}");
Console.WriteLine($"  Item2 = {datos.Item2}");
Console.WriteLine($"  Item3 = {datos.Item3}");
Console.WriteLine();

// --- Desestructurar tupla ---
Console.WriteLine("--- Desestructurar tupla ---");
(string nom, int niv, int pts) = ("María", 30, 2200);
Console.WriteLine($"  nombre = {nom}");
Console.WriteLine($"  nivel  = {niv}");
Console.WriteLine($"  puntos = {pts}");
Console.WriteLine();

// --- Descarte con _ ---
Console.WriteLine("--- Descarte con _ ---");
var (nombreJugador, _, puntosJugador) = ("Luis", 99, 3000);
Console.WriteLine($"  Solo nos importa: {nombreJugador} con {puntosJugador} puntos");
Console.WriteLine();

// --- Igualdad de tuplas ---
Console.WriteLine("--- Igualdad de tuplas ---");
var a = (1, 2);
var b = (1, 2);
var c = (1, 3);
Console.WriteLine($"  (1,2) == (1,2) → {a == b}  (mismos valores)");
Console.WriteLine($"  (1,2) == (1,3) → {a == c}  (distinto segundo valor)");
Console.WriteLine();

// --- Tupla como resultado ---
Console.WriteLine("--- Tupla como resultado de operaciones ---");
int precio = 100;
int iva = 21;
int total = precio + iva;
Console.WriteLine($"  Precio: {precio}€, IVA: {iva}€, Total: {total}€");
Console.WriteLine($"  Se puede devolver como (precio, iva, total) = ({precio}, {iva}, {total})");
