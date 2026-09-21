// 04-Operadores.cs
// Ejemplo: Operadores aritméticos, relacionales, lógicos, asignación.
// Ejecutar: dotnet run 04-Operadores.cs

Console.WriteLine("=== OPERADORES ===");
Console.WriteLine();

// --- Aritméticos ---
Console.WriteLine("--- Operadores aritméticos ---");
int a = 17, b = 5;
Console.WriteLine($"  {a} + {b} = {a + b}   (suma)");
Console.WriteLine($"  {a} - {b} = {a - b}   (resta)");
Console.WriteLine($"  {a} * {b} = {a * b}   (multiplicación)");
Console.WriteLine($"  {a} / {b} = {a / b}   (división entera: {a}/{b} = {17/5})");
Console.WriteLine($"  {a} % {b} = {a % b}   (módulo: resto de {a}/{b})");
Console.WriteLine();

// Cuidado con la división entre enteros
Console.WriteLine("  ⚠️ División entre enteros:");
Console.WriteLine($"    10 / 3 = {10 / 3}  (no 3.33, se trunca)");
Console.WriteLine($"    (double)10 / 3 = {(double)10 / 3}  (conversión → decimal)");
Console.WriteLine();

// --- Asignación ---
Console.WriteLine("--- Operadores de asignación ---");
int x = 10;
Console.WriteLine($"  x = {x}");

x += 5;   // x = x + 5
Console.WriteLine($"  x += 5  → {x}");

x -= 3;   // x = x - 3
Console.WriteLine($"  x -= 3  → {x}");

x *= 2;   // x = x * 2
Console.WriteLine($"  x *= 2  → {x}");

x /= 4;   // x = x / 4
Console.WriteLine($"  x /= 4  → {x}");

x %= 3;   // x = x % 3
Console.WriteLine($"  x %= 3  → {x}");

Console.WriteLine();
Console.WriteLine("  ⚠️ Cuidado: += no es lo mismo que =+");
Console.WriteLine("    x += 5  → suma 5 a x");
Console.WriteLine("    x =+ 5  → asigna +5 a x (lo mismo que x = 5)");
Console.WriteLine();

// --- Relacionales ---
Console.WriteLine("--- Operadores relacionales ---");
int edad = 25;
Console.WriteLine($"  Edad: {edad}");
Console.WriteLine($"  edad == 25 → {edad == 25}  (igual)");
Console.WriteLine($"  edad != 25 → {edad != 25}  (diferente)");
Console.WriteLine($"  edad > 18  → {edad > 18}   (mayor que)");
Console.WriteLine($"  edad < 18  → {edad < 18}   (menor que)");
Console.WriteLine($"  edad >= 25 → {edad >= 25}  (mayor o igual)");
Console.WriteLine($"  edad <= 30 → {edad <= 30}  (menor o igual)");
Console.WriteLine();

// --- Lógicos ---
Console.WriteLine("--- Operadores lógicos ---");
bool tieneCuenta = true;
bool tieneEdad = true;

bool puedeAcceder = tieneCuenta && tieneEdad;
Console.WriteLine($"  tieneCuenta && tieneEdad → {puedeAcceder}  (AND: ambas deben ser true)");

bool esFinDeSemana = false;
bool esFestivo = true;
bool noTrabaja = esFinDeSemana || esFestivo;
Console.WriteLine($"  esFinDeSemana || esFestivo → {noTrabaja}  (OR: al menos una true)");

bool noEsActivo = !true;
Console.WriteLine($"  !true → {noEsActivo}  (NOT: invierte el valor)");
Console.WriteLine();

// Tabla de verdad AND
Console.WriteLine("  Tabla de verdad AND:");
Console.WriteLine("    true  && true  = true");
Console.WriteLine("    true  && false = false");
Console.WriteLine("    false && true  = false");
Console.WriteLine("    false && false = false");
Console.WriteLine();

// Cortocircuito
Console.WriteLine("  Cortocircuito (short-circuit):");
int numero = 0;
bool resultadoCorto = numero != 0 && 10 / numero > 2;
Console.WriteLine($"  numero != 0 && 10/numero > 2 → {resultadoCorto}  (si numero es 0, NO evalúa la división)");
Console.WriteLine();

// De Morgan
Console.WriteLine("  Leyes de De Morgan:");
bool p = true, q = false;
Console.WriteLine($"    !(p && q) = {!(p && q)}  =  !p || !q = {!p || !q}");
Console.WriteLine($"    !(p || q) = {!(p || q)}  =  !p && !q = {!p && !q}");
Console.WriteLine();

// --- Ternario y coalescencia ---
Console.WriteLine("--- Operador ternario y coalescencia ---");
int nota = 7;
string resultado = nota >= 5 ? "Aprobado" : "Suspenso";
Console.WriteLine($"  nota = {nota} → {resultado}  (ternario)");

string? nombre = null;
string nombreFinal = nombre ?? "Anónimo";
Console.WriteLine($"  nombre = null → {nombreFinal}  (coalescencia ??)");

nombre = "Ana";
nombreFinal = nombre ?? "Anónimo";
Console.WriteLine($"  nombre = \"Ana\" → {nombreFinal}  (no es null, mantiene valor)");

// ??= — asignación nula condicional
string? saludo = null;
saludo ??= "Hola mundo";
Console.WriteLine($"  saludo ??= \"Hola mundo\" → {saludo}  (solo asigna si es null)");
Console.WriteLine();

// --- Precedencia ---
Console.WriteLine("--- Precedencia de operadores ---");
int resultado2 = 20 - 4 * 2 + 15 / 3;
Console.WriteLine($"  20 - 4 * 2 + 15 / 3 = {resultado2}");
Console.WriteLine("  Orden: * y / primero (izq → der), luego + y - (izq → der)");
Console.WriteLine($"    4 * 2 = 8, 15 / 3 = 5");
Console.WriteLine($"    20 - 8 + 5 = {resultado2}");
