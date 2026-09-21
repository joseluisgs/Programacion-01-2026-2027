// 09-StructBasic.cs
// Ejemplo: Structs y Enums — tipos de valor compuestos
// Ejecutar: dotnet run 09-StructBasic.cs

Console.WriteLine("=== STRUCTS Y ENUMS ===");
Console.WriteLine();

// --- Enums ---
Console.WriteLine("--- Enums (valores con nombre) ---");
DiaSemana hoy = DiaSemana.Miercoles;
Console.WriteLine($"  Hoy es: {hoy} (valor numérico: {(int)hoy})");

bool esFinDeSemana = (hoy == DiaSemana.Sabado || hoy == DiaSemana.Domingo);
Console.WriteLine($"  ¿Es fin de semana? {esFinDeSemana}");
Console.WriteLine();

// --- Structs ---
Console.WriteLine("--- Structs (tipos de valor compuestos) ---");
Punto origen = new() { X = 0, Y = 0 };
Punto destino = new() { X = 10, Y = 20 };
Console.WriteLine($"  Origen:  ({origen.X}, {origen.Y})");
Console.WriteLine($"  Destino: ({destino.X}, {destino.Y})");
Console.WriteLine();

// --- Struct: Jugador con Enum ---
Console.WriteLine("--- Struct: Jugador (con Enum dentro) ---");
Jugador jugador1 = new() { Nombre = "Ana", Nivel = 25, Puntos = 1500, Rango = NivelRango.Platino };
Console.WriteLine($"  Nombre:  {jugador1.Nombre}");
Console.WriteLine($"  Nivel:   {jugador1.Nivel}");
Console.WriteLine($"  Puntos:  {jugador1.Puntos}");
Console.WriteLine($"  Rango:   {jugador1.Rango}");

// Copia (se copia el contenido)
Jugador jugador2 = jugador1;
jugador2.Nombre = "Carlos";
jugador2.Rango = NivelRango.Oro;
Console.WriteLine($"  Después de copiar y cambiar nombre y rango:");
Console.WriteLine($"  Original: {jugador1.Nombre} — {jugador1.Rango}  (NO cambia)");
Console.WriteLine($"  Copia:    {jugador2.Nombre} — {jugador2.Rango}  (SÍ cambia)");
Console.WriteLine();

// --- Copiar un struct (se copia el contenido) ---
Console.WriteLine("--- Copia de struct ---");
Punto copia = origen;
copia.X = 99;
Console.WriteLine($"  Origen:  ({origen.X}, {origen.Y})  (NO cambia)");
Console.WriteLine($"  Copia:   ({copia.X}, {copia.Y})  (SÍ cambia tras modificar)");
Console.WriteLine();

// --- Struct vs Tupla ---
Console.WriteLine("--- Struct vs Tupla ---");
Console.WriteLine("  Tupla:   var punto = (5, 3)      → rápido, poco descriptivo");
Console.WriteLine("  Struct:  Punto p = new() {X=5,Y=3} → claro, con nombre");
Console.WriteLine();

// --- Resumen ---
Console.WriteLine("--- Resumen ---");
Console.WriteLine("  Enum:  conjunto de valores con nombre (DiaSemana, NivelRango)");
Console.WriteLine("  Struct: tipo de valor compuesto con campos (Punto, Jugador)");
Console.WriteLine("  Los structs pueden tener enums como campos → datos más organizados");

// Enums y Structs: van al final en Top-Level Statements (son declaraciones de tipo)
enum DiaSemana { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo }

enum NivelRango { Bronce, Plata, Oro, Platino }

struct Punto
{
    public int X;
    public int Y;
}

struct Jugador
{
    public string Nombre;
    public int Nivel;
    public int Puntos;
    public NivelRango Rango;
}
