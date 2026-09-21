// 02-TiposDatos.cs
// Ejemplo: Tipos de datos en C# — enteros, decimales, booleanos, texto.
// Ejecutar: dotnet run 02-TiposDatos.cs

Console.WriteLine("=== TIPOS DE DATOS ===");
Console.WriteLine();

// Enteros con signo
sbyte temperatura = -10;
short poblacion = 3500;
int distancia = 1_500_000;
long kilometrosEstelares = 9_000_000_000_000L;

Console.WriteLine("--- Enteros con signo ---");
Console.WriteLine($"  sbyte  : {temperatura}  (1 byte, -128 a 127)");
Console.WriteLine($"  short  : {poblacion}  (2 bytes, -32K a 32K)");
Console.WriteLine($"  int    : {distancia:N0}  (4 bytes, ±2.147M)");
Console.WriteLine($"  long   : {kilometrosEstelares:N0}  (8 bytes)");
Console.WriteLine();

// Enteros sin signo
byte porcentaje = 85;
ushort edad = 25;
uint usuarios = 1_500_000;
ulong visitas = 3_000_000_000UL;

Console.WriteLine("--- Enteros sin signo ---");
Console.WriteLine($"  byte   : {porcentaje}  (0 a 255)");
Console.WriteLine($"  ushort : {edad}  (0 a 65K)");
Console.WriteLine($"  uint   : {usuarios:N0}  (0 a 4.294M)");
Console.WriteLine($"  ulong  : {visitas:N0}  (0 a 18.4E)");
Console.WriteLine();

// Decimales
float piFloat = 3.14f;
double piDouble = 3.14159265358979;
decimal saldo = 1234.56m;

Console.WriteLine("--- Decimales ---");
Console.WriteLine($"  float  : {piFloat}  (4 bytes, ~6-9 dígitos)");
Console.WriteLine($"  double : {piDouble}  (8 bytes, ~15-17 dígitos)");
Console.WriteLine($"  decimal: {saldo}  (16 bytes, ~28-29 dígitos, DINERO)");
Console.WriteLine();

// Otros tipos
bool esMayorEdad = true;
char inicial = 'A';
string nombre = "Ana García";

Console.WriteLine("--- Otros tipos ---");
Console.WriteLine($"  bool   : {esMayorEdad}  (true o false)");
Console.WriteLine($"  char   : {inicial}  (un carácter Unicode)");
Console.WriteLine($"  string : {nombre}  (texto)");
Console.WriteLine();

// Tipos adicionales
DateTime ahora = DateTime.Now;
DateOnly hoy = DateOnly.FromDateTime(ahora);
TimeOnly hora = TimeOnly.FromDateTime(ahora);
Guid id = Guid.NewGuid();

Console.WriteLine("--- Tipos adicionales ---");
Console.WriteLine($"  DateTime : {ahora:dd/MM/yyyy HH:mm:ss}");
Console.WriteLine($"  DateOnly : {hoy}");
Console.WriteLine($"  TimeOnly : {hora}");
Console.WriteLine($"  Guid     : {id}");
Console.WriteLine();

// var — inferencia de tipos
var edad2 = 25;           // int
var mensaje = "Hola";     // string
var pi2 = 3.14;           // double
var activo = true;        // bool

Console.WriteLine("--- Inferencia con var ---");
Console.WriteLine($"  var edad2   = 25;    → tipo: Int32");
Console.WriteLine($"  var mensaje = \"Hola\"; → tipo: String");
Console.WriteLine($"  var pi2     = 3.14;  → tipo: Double");
Console.WriteLine($"  var activo  = true;  → tipo: Boolean");
