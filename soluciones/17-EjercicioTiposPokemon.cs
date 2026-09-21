// Ejercicio 15: Tipos de Pokémon (Enumeración)
// Conceptos: enum, ternario, conversión a int
// Ejecutar: dotnet run ej15.cs

Console.OutputEncoding = System.Text.Encoding.UTF8; // Para mostrar emojis correctamente

Console.WriteLine("=== TIPOS DE POKÉMON ===");
Console.WriteLine();

TipoPokemon pokemon1 = TipoPokemon.Electrico;
TipoPokemon pokemon2 = TipoPokemon.Fuego;

Console.WriteLine($"Pokémon 1: {pokemon1} (valor numérico: {(int)pokemon1})");
Console.WriteLine($"Pokémon 2: {pokemon2} (valor numérico: {(int)pokemon2})");
Console.WriteLine();

// Descripción con ternario
string descripcion1 = pokemon1 == TipoPokemon.Fuego ? "🔥 Fuerte contra Planta, débil contra Agua"
                    : pokemon1 == TipoPokemon.Agua ? "💧 Fuerte contra Fuego, débil contra Planta"
                    : pokemon1 == TipoPokemon.Planta ? "🌿 Fuerte contra Agua, débil contra Fuego"
                    : pokemon1 == TipoPokemon.Electrico ? "⚡ Fuerte contra Agua, débil contra Planta"
                    : "⚪ Sin ventajas ni desventajas";

string descripcion2 = pokemon2 == TipoPokemon.Fuego ? "🔥 Fuerte contra Planta, débil contra Agua"
                    : pokemon2 == TipoPokemon.Agua ? "💧 Fuerte contra Fuego, débil contra Planta"
                    : pokemon2 == TipoPokemon.Planta ? "🌿 Fuerte contra Agua, débil contra Fuego"
                    : pokemon2 == TipoPokemon.Electrico ? "⚡ Fuerte contra Agua, débil contra Planta"
                    : "⚪ Sin ventajas ni desventajas";

Console.WriteLine($"  {pokemon1}: {descripcion1}");
Console.WriteLine($"  {pokemon2}: {descripcion2}");
Console.WriteLine();

// Todos los tipos
Console.WriteLine("Todos los tipos disponibles:");
Console.WriteLine("  0 - Fuego");
Console.WriteLine("  1 - Agua");
Console.WriteLine("  2 - Planta");
Console.WriteLine("  3 - Electrico");
Console.WriteLine("  4 - Normal");

// Enum: va al final en Top-Level Statements (es una declaración de tipo)
enum TipoPokemon { Fuego, Agua, Planta, Electrico, Normal }
