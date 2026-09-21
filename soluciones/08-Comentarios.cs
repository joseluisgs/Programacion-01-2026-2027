// 07-Comentarios.cs
// Ejemplo: Comentarios y documentación en C#.
// Ejecutar: dotnet run 07-Comentarios.cs

// Este es un comentario de una línea.
// Úsalo para explicar el "por qué" del código, no el "qué".

/*
    Este es un comentario
    de varias líneas.
    Úsalo para explicar bloques largos de código.
*/

Console.WriteLine("=== COMENTARIOS Y DOCUMENTACIÓN ===");
Console.WriteLine();

// --- Bueno vs Malo ---
Console.WriteLine("--- Comentar el POR QUÉ, no el QUÉ ---");

// ❌ MALO: el comentario repite lo que hace el código
int edad = 25;  // asigna 25 a edad (redundante)

// ✅ BUENO: el comentario explica POR QUÉ
int edadMinima = 18;  // edad mínima para acceder al contenido premium
bool puedeAcceder = edad >= edadMinima;

Console.WriteLine($"  Edad: {edad}, Edad mínima: {edadMinima}");
Console.WriteLine($"  Puede acceder: {puedeAcceder}");
Console.WriteLine();

// --- XML Documentation ---
Console.WriteLine("--- Documentación XML ---");
Console.WriteLine("  Se usa /// antes de métodos/clases para generar documentación:");
Console.WriteLine();
Console.WriteLine("  /// <summary>");
Console.WriteLine("  /// Calcula el IVA de un precio.");
Console.WriteLine("  /// </summary>");
Console.WriteLine("  /// <param name=\"precio\">Precio base</param>");
Console.WriteLine("  /// <param name=\"porcentaje\">Porcentaje de IVA</param>");
Console.WriteLine("  /// <returns>Precio con IVA incluido</returns>");
Console.WriteLine();

// Ejemplo de método documentado
double precioBase = 100;
double iva = CalcularIva(precioBase, 21);
Console.WriteLine($"  Precio base: {precioBase}€");
Console.WriteLine($"  IVA 21%: {iva}€");
Console.WriteLine($"  Total: {precioBase + iva}€");

// --- Regiones ---
Console.WriteLine();
Console.WriteLine("--- Regiones (#region / #endregion) ---");
Console.WriteLine("  Útiles para organizar código en bloques plegables en el IDE:");
Console.WriteLine();
Console.WriteLine("  #region Métodos auxiliares");
Console.WriteLine("  // ... código aquí ...");
Console.WriteLine("  #endregion");

// Método auxiliar (documentado con XML)
/// <summary>
/// Calcula el IVA de un precio.
/// </summary>
/// <param name="precio">Precio base</param>
/// <param name="porcentaje">Porcentaje de IVA (ej: 21 para 21%)</param>
/// <returns>Precio con IVA incluido</returns>
double CalcularIva(double precio, double porcentaje)
{
    return precio * porcentaje / 100;
}
