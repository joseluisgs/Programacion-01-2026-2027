// 03-VariablesConstantes.cs
// Ejemplo: Variables, constantes, literales y enumeraciones.
// Ejecutar: dotnet run 03-VariablesConstantes.cs

Console.WriteLine("=== VARIABLES, CONSTANTES Y LITERALES ===");
Console.WriteLine();

// --- Variables ---
Console.WriteLine("--- Variables ---");
int edad = 25;
string nombre = "Carlos";
double precio = 19.99;
bool esActivo = true;

Console.WriteLine($"  Edad: {edad}");
Console.WriteLine($"  Nombre: {nombre}");
Console.WriteLine($"  Precio: {precio}€");
Console.WriteLine($"  Activo: {esActivo}");

// Reasignación
edad = 26;
Console.WriteLine($"  Edad después de cumpleaños: {edad}");
Console.WriteLine();

// --- Constantes ---
Console.WriteLine("--- Constantes ---");
const double Iva = 21.0;
const string Moneda = "EUR";
const int MaximoIntentos = 3;

Console.WriteLine($"  IVA: {Iva}%");
Console.WriteLine($"  Moneda: {Moneda}");
Console.WriteLine($"  Máximo intentos: {MaximoIntentos}");

// La siguiente línea DARÍA ERROR de compilación:
// Iva = 22.0;  // Error CS0131: No se puede asignar a una constante
Console.WriteLine("  (Las constantes no se pueden modificar)");
Console.WriteLine();

// --- Literales ---
Console.WriteLine("--- Literales ---");
int entero = 42;           // literal entero
double decimal2 = 3.14;    // literal decimal
string texto = "Hola";     // literal texto
bool booleano = true;      // literal booleano
char caracter = 'A';       // literal carácter
long grande = 1_000_000L;  // literal long con guión bajo

Console.WriteLine($"  Entero: {entero}");
Console.WriteLine($"  Decimal: {decimal2}");
Console.WriteLine($"  Texto: {texto}");
Console.WriteLine($"  Booleano: {booleano}");
Console.WriteLine($"  Carácter: {caracter}");
Console.WriteLine($"  Long con guión bajo: {grande:N0}");
Console.WriteLine();

// --- Enumeraciones ---
Console.WriteLine("--- Enumeraciones ---");
Console.WriteLine("  Un enum define valores con nombre:");
Console.WriteLine("  DiaSemana: Lunes=0, Martes=1, Miercoles=2...");
Console.WriteLine("  Se usa con comparaciones: hoy == DiaSemana.Sabado");
Console.WriteLine();

// --- Scope (alcance) ---
Console.WriteLine("--- Scope (alcance) ---");
{
    int x = 10;
    Console.WriteLine($"  Dentro del bloque: x = {x}");
}
// La siguiente línea DARÍA ERROR porque x ya no existe:
// Console.WriteLine(x);  // Error CS0103: El nombre 'x' no existe
Console.WriteLine("  Fuera del bloque: x ya no existe");
Console.WriteLine();

// --- Lifetime (duración de vida) ---
Console.WriteLine("--- Lifetime ---");
int hora = DateTime.Now.Hour;
string mensaje = hora < 12 ? "Buenos días" : "Buenas tardes";
Console.WriteLine($"  {mensaje} (la variable se asigna según la hora)");
