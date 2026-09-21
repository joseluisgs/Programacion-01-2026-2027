// 05-Tuplas.cs
// Ejemplo: Tuplas — agrupar datos de diferentes tipos
// Ejecutar: dotnet run 05-Tuplas.cs

Console.WriteLine("=== TUPLAS ===");
Console.WriteLine();

// --- Tupla básica ---
Console.WriteLine("--- Tupla básica (con Item1, Item2) ---");
var persona = ("Ana", 25);
Console.WriteLine($"  persona.Item1 = {persona.Item1}");
Console.WriteLine($"  persona.Item2 = {persona.Item2}");
Console.WriteLine();

// --- Tupla con nombres ---
Console.WriteLine("--- Tupla con nombres (más legible) ---");
(string nombre, int edad) jugador = ("Carlos", 42);
Console.WriteLine($"  jugador.nombre = {jugador.nombre}");
Console.WriteLine($"  jugador.edad = {jugador.edad}");
Console.WriteLine();

// --- Tupla con 3 elementos ---
Console.WriteLine("--- Tupla con 3 elementos ---");
var pokemon = ("Pikachu", 25, 9800);
Console.WriteLine($"  Nombre: {pokemon.Item1}, Nivel: {pokemon.Item2}, CP: {pokemon.Item3}");
Console.WriteLine();

// --- Desestructurar tupla ---
Console.WriteLine("--- Desestructurar tupla ---");
(string nombreAlumno, int notaAlumno) = ("María", 8);
Console.WriteLine($"  nombre = {nombreAlumno}, nota = {notaAlumno}");
Console.WriteLine();

// --- Descarte con _ ---
Console.WriteLine("--- Descarte con _ ---");
var (nom, _) = ("Luis", 30);  // Solo nos importa el nombre
Console.WriteLine($"  Solo el nombre: {nom}");
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
