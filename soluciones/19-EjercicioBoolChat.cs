// Ejercicio 34: Booleano a Texto para un Chat
// Conceptos: bool, .ToString(), ternario, concatenación
// Ejecutar: dotnet run ej34.cs

Console.WriteLine("=== BOOLEANO A TEXTO PARA CHAT ===");
Console.WriteLine();

string usuario = "Shadow";
bool enLinea = true;

// Forma 1: ToString()
string estado1 = enLinea.ToString();
Console.WriteLine($"  .ToString(): {usuario} está {estado1}");

// Forma 2: Ternario (mucho más legible)
string estado2 = enLinea ? "en línea" : "desconectado";
Console.WriteLine($"  Ternario:   {usuario} está {estado2}");

Console.WriteLine();

// Con datos de usuario
bool tieneNotificaciones = false;
bool esSuscriptor = true;

string msgNotif = tieneNotificaciones ? "notificaciones activadas" : "sin notificaciones";
string msgSub = esSuscriptor ? "suscriptor premium" : "usuario free";

Console.WriteLine($"  {usuario}: {msgNotif}, {msgSub}");
Console.WriteLine($"  Mensaje: ¡Hola {usuario}! Estás {estado2} con {msgSub}.");
