// 05-Conversiones.cs
// Ejemplo: Conversiones de tipo — implícitas, explícitas, Parse, TryParse, Convert.
// Ejecutar: dotnet run 05-Conversiones.cs

Console.WriteLine("=== CONVERSIONES DE TIPO ===");
Console.WriteLine();

// --- Implícitas (automáticas, sin pérdida de datos) ---
Console.WriteLine("--- Conversiones implícitas ---");
int entero = 42;
long largo = entero;      // int → long (seguro)
float precioFloat = 19.99f;
double precioDouble = precioFloat;  // float → double (seguro)

Console.WriteLine($"  int → long: {entero} → {largo}  ✅");
Console.WriteLine($"  float → double: {precioFloat} → {precioDouble}  ✅");
Console.WriteLine();

// char → int (código Unicode)
char letra = 'A';
int codigo = letra;
Console.WriteLine($"  char → int: '{letra}' → {codigo}  (código Unicode)");
Console.WriteLine();

// --- Explícitas (casting — puede perder datos) ---
Console.WriteLine("--- Conversiones explícitas (casting) ---");
double pi = 3.14;
int enteroTruncado = (int)pi;
Console.WriteLine($"  (int)3.14 = {enteroTruncado}  ⚠️ Trunca, no redondea");

long grande = 3_000_000_000L;
int pequeno = (int)grande;
Console.WriteLine($"  (int)3.000.000.000 = {pequeno}  ⚠️ Overflow: resultado inesperado");
Console.WriteLine();

// --- Parse ---
Console.WriteLine("--- Parse (lanza excepción si falla) ---");
string textoNumero = "42";
int numero = int.Parse(textoNumero);
Console.WriteLine($"  int.Parse(\"42\") = {numero}");

double decimal2 = double.Parse("3.14");
Console.WriteLine($"  double.Parse(\"3.14\") = {decimal2}");

// La siguiente línea DARÍA FormatException:
// int error = int.Parse("hola");
Console.WriteLine("  ⚠️ int.Parse(\"hola\") → FormatException (no compila sin try-catch)");
Console.WriteLine();

// --- TryParse (seguro, no lanza excepción) ---
Console.WriteLine("--- TryParse (seguro) ---");
string input1 = "42";
bool exito1 = int.TryParse(input1, out int resultado1);
Console.WriteLine($"  int.TryParse(\"42\") → éxito={exito1}, valor={resultado1}");

string input2 = "abc";
bool exito2 = int.TryParse(input2, out int resultado2);
Console.WriteLine($"  int.TryParse(\"abc\") → éxito={exito2}, valor={resultado2}");
Console.WriteLine();

// --- Convert ---
Console.WriteLine("--- Convert (tolerante con null) ---");
int desdeInt = Convert.ToInt32(42.7);  // Trunca
Console.WriteLine($"  Convert.ToInt32(42.7) = {desdeInt}");

string texto = Convert.ToString(42);
Console.WriteLine($"  Convert.ToString(42) = \"{texto}\"");

int desdeNull = Convert.ToInt32(null);
Console.WriteLine($"  Convert.ToInt32(null) = {desdeNull}  (retorna 0)");
Console.WriteLine();

// --- ChangeType ---
Console.WriteLine("--- Convert.ChangeType (genérico) ---");
object valor = "42";
int entero2 = Convert.ToInt32(valor);
double doble = Convert.ToDouble(valor);
Console.WriteLine($"  Convert.ToInt32(\"42\") = {entero2}");
Console.WriteLine($"  Convert.ToDouble(\"42\") = {doble}");
Console.WriteLine();

// --- Errores comunes ---
Console.WriteLine("--- Errores comunes ---");

// División entre enteros
int a = 10, b2 = 3;
double mal = a / b2;       // 3.0, no 3.33
double bien = (double)a / b2;  // 3.333...
Console.WriteLine($"  10 / 3 = {mal}  ❌ (división entera)");
Console.WriteLine($"  (double)10 / 3 = {bien:F3}  ✅ (conversión previa)");
Console.WriteLine();

// String interpolation ya hace conversión
int puntos = 100;
Console.WriteLine($"  String interpolation: \"Tienes {puntos} puntos\"  (ToString() implícito)");
