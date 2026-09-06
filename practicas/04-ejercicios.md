# Batería de Ejercicios: Fundamentos de Programación con C# 14

**Instrucciones:** Para cada ejercicio, escribe el código completo en C# usando Top-Level Statements dentro de un archivo `.cs`. Ejecuta cada ejercicio con `dotnet run tu_ejercicio.cs`. Recuerda: **primero el diseño en papel, luego la codificación**.

---

### Bloque I: Primeros Contactos y Estructura del Programa (Ejercicios 1-5)

**Ejercicio 1: Tu Carta de Presentación**
Crea un archivo `ej01.cs` que muestre en la consola tu carta de presentación: nombre, edad, ciudad y tu lenguaje de programación favorito (aunque sea mentira, esto es C#). Incluye al inicio un comentario multilínea con tu nombre y un `//` con el propósito del programa.

**Ejercicio 2: Perfil de TikTok**
Crea un archivo `ej02.cs` que declare variables con tu información de perfil: nombre de usuario (`string`), seguidores (`int`), videosPublicados (`int`), esVerificado (`bool`). Muestra todo con interpolación. Luego calcula y muestra los seguidores por video publicado.

**Ejercicio 3: Top-Level Statements: Antes y Ahora**
Crea un archivo `ej03.cs` que imprima "Mi primer programa en C# 14". En un comentario, escribe cómo se vería la misma funcionalidad usando la estructura clásica con `class Program` y `static void Main`. Compara la cantidad de código.

**Ejercicio 4: Usando `using static` para Limpieza**
Crea un archivo `ej04.cs` con `using static System.Console;` al inicio. Pide al usuario su nombre con `ReadLine()` y muestra un saludo con `WriteLine()`, todo sin escribir `Console.` cada vez. En un comentario, explica cuándo es útil `using static`.

**Ejercicio 5: Calculadora de Edad en Días**
Crea un archivo `ej05.cs` que pida al usuario su edad en años. Calcula y muestra cuántos días ha vivido aproximadamente (edad × 365). Usa interpolación para el mensaje: "Tienes {edad} años, que son aproximadamente {dias} días".

---

### Bloque II: Variables y Tipos de Datos (Ejercicios 6-12)

**Ejercicio 6: Ficha de un Pokémon**
Crea un archivo `ej06.cs`. Un Pokémon tiene esta información: `id` (int, 25), `nombre` (string, "Pikachu"), `peso` (double, 6.0), `ataque` (int, 55), `esLegendario` (bool, false). Declara las variables, asígnalas y muestra la ficha completa con interpolación.

**Ejercicio 7: Estadísticas de un Videojuego**
Crea un archivo `ej07.cs`. En tu juego favorito tienes: `nivel` (int, 42), `experiencia` (long, 1250000), `vida` (double, 85.5), `nombrePersonaje` (string, "Shadow"). Usa `var` para declarar las variables y muestra el tipo inferido con `GetType().Name` junto al valor.

**Ejercicio 8: Conociendo los Tipos Numéricos**
Crea un archivo `ej08.cs` que muestre una tabla con los tipos numéricos de C#: `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal`. Para cada uno, muestra su tamaño en bytes, valor mínimo y máximo usando las constantes del sistema (ej: `int.MinValue`).

**Ejercicio 9: Tu Playlist de Spotify**
Crea un archivo `ej09.cs` que declare: `string cancion = "Blinding Lights";` `string artista = "The Weeknd";` `int duracionSegundos = 200;` `double valoracion = 4.7;`. Muestra: "Escuchando {cancion} de {artista} - {duracionSegundos} segundos - Valoración: {valoracion}/5".

**Ejercicio 10: Redes Sociales: Likes y Comentarios**
Crea un archivo `ej10.cs` que declare `int likes = 15420;` `int comentarios = 347;` `bool esPublico = true;`. Calcula la tasa de interacción: `comentarios * 100.0 / likes`. Muestra los datos y la tasa con 2 decimales.

**Ejercicio 11: El Problema de `int` para Precios**
Crea un archivo `ej11.cs` que calcule `10 / 3` usando `int` y luego usando `decimal`. Muestra ambos resultados. Explica en un comentario por qué usar `int` para precios es un error grave (ej: `10 / 3 = 3` en enteros, pero debería ser `3.33€`).

**Ejercicio 12: Tu Perfil de Gamer**
Crea un archivo `ej12.cs` que genere un `Guid` aleatorio con `Guid.NewGuid()` como "ID de jugador" y muestre la fecha y hora actual con `DateTime.Now` como "Última conexión". Muestra ambos valores.

---

### Bloque III: Constantes y Enumeraciones (Ejercicios 13-17)

**Ejercicio 13: Configuración de un Juego**
Crea un archivo `ej13.cs` con constantes del juego: `const int VIDAS_MAXIMAS = 3;` `const double VELOCIDAD_BASE = 1.5;` `const string NIVEL_INICIAL = "Bosque Oscuro";`. Muestra la configuración. Intenta modificar `VIDAS_MAXIMAS` dentro del código y comenta qué error da.

**Ejercicio 14: Constantes de un Pokémon**
Crea un archivo `ej14.cs` con: `const int CP_MAX = 4144;` (CP máximo en Pokémon GO) `const double PesoPikachu = 6.0;`. Declara una variable `int cpActual = 1500;` y muestra si el Pokémon puede ser potenciado (cpActual < CP_MAX).

**Ejercicio 15: Tipos de Pokémon**
Crea un archivo `ej15.cs` que defina una enumeración `TipoPokemon { Fuego, Agua, Planta, Electrico, Normal }`. Declara una variable de tipo `TipoPokemon`, asígnale `TipoPokemon.Electrico` y muéstrala.

**Ejercicio 16: Rangos de un Videojuego Competitivo**
Crea un archivo `ej16.cs` que defina `enum Rango { Bronce = 1, Plata = 2, Oro = 3, Platino = 4, Diamante = 5, Leyenda = 6 }`. Declara una variable, asígnale `Rango.Oro` y muestra su nombre y valor numérico.

**Ejercicio 17: Estados de una Partida Online**
Crea un archivo `ej17.cs` que defina `enum EstadoPartida { Esperando, EnCurso, Pausada, Finalizada, Cancelada }`. Declara una variable, asígnale `EstadoPartida.EnCurso` y muestra el estado.

---

### Bloque IV: Entrada y Salida de Datos (Ejercicios 18-24)

**Ejercicio 18: Creando tu Personaje**
Crea un archivo `ej18.cs` que pida al usuario el nombre de su personaje y su clase (guerrero, mago, arquero). Muestra: "¡{nombre}, el {clase}, ha entrado al mundo de Azeroth!".

**Ejercicio 19: Calculadora de IMC**
Crea un archivo `ej19.cs` que pida el peso (kg) y la altura (m) al usuario. Calcula el IMC = peso / (altura * altura). Usa `double.TryParse()` para leer los datos de forma segura. Muestra el resultado y la clasificación (bajo peso, normal, sobrepeso, obesidad).

**Ejercicio 20: Conversor de Monedas de Videojuego**
Crea un archivo `ej20.cs` que pida cuántos "oros" tiene el jugador (entero). En tu juego, 1000 oros = 1 diamante. Muestra cuántos diamantes puede obtener (división entera) y cuántos oros le sobran (módulo).

**Ejercicio 21: Registro de Usuario**
Crea un archivo `ej21.cs` que pida nombre, email y contraseña. Muestra un resumen con interpolación. Explica en un comentario por qué NUNCA se deberían mostrar las contraseñas en producción.

**Ejercicio 22: Temperature Check para eSports**
Crea un archivo `ej22.cs` que pida la temperatura del servidor (decimal). Si es < 30, muestra "Servidor OK". Si es >= 30 y < 50, muestra "Advertencia: temperatura alta". Si es >= 50, muestra "CRÍTICO: servidor sobrecalentado".

**Ejercicio 23: Precio con IVA de una Skin**
Crea un archivo `ej23.cs` que pida el precio base de una skin (decimal). Calcula el IVA (21%) y el precio final. Muestra: "Skin: {precio}€ + {iva}€ IVA = {precioFinal}€".

**Ejercicio 24: Resumen de Compra en Steam**
Crea un archivo `ej22.cs` que pida el precio de un juego y la cantidad de juegos. Calcula el subtotal, el descuento del 10% si se gastan más de 50€, y el total final. Muestra el desglose.

---

### Bloque V: Operadores Aritméticos y Asignación (Ejercicios 25-30)

**Ejercicio 25: Estadísticas de un Streamer**
Crea un archivo `ej25.cs` con `var seguidoresTwitch = 150000;` `var seguidoresYouTube = 850000;` `var ratio = (double)seguidoresYouTube / seguidoresTwitch;`. Calcula y muestra la suma de seguidores y el ratio entre plataformas.

**Ejercicio 26: XP y Subida de Nivel**
Crea un archivo `ej26.cs` que declare `int xpActual = 0;`. Simula ganar 250 XP con `xpActual += 250;`, luego ganar el doble con `xpActual *= 2;`, luego ganar 100 más. Muestra el XP después de cada acción. El nivel sube cada 1000 XP: muestra en qué nivel está.

**Ejercicio 27: Precedencia en un Videojuego**
Crea un archivo `ej27.cs`. En un juego, el daño se calcula: `dañoBase * multiplicador - defensa / 2`. Declara `dañoBase = 100, multiplicador = 2, defensa = 20;`. Calcula el daño final y explique por qué `*` y `/` se ejecutan antes que `-`.

**Ejercicio 28: División de Botín entre Jugadores**
Crea un archivo `ej28.cs`. Un grupo de 4 jugadores obtiene 1550 monedas. Usa división entera `/` para saber cuántas monedas recibe cada uno y módulo `%` para saber cuántas sobran. Muestra ambos resultados.

**Ejercicio 29: Par o Impar: Modo Oscuro**
Crea un archivo `ej29.cs` que pida un número al usuario. Si es par, muestra "Modo Oscuro activado". Si es impar, muestra "Modo Claro activado". Usa `%` para determinar la paridad.

**Ejercicio 30: Inversión en Criptomonedas**
Crea un archivo `ej30.cs` con `const double COMISION = 0.01;` (1%). Pide el monto en euros y calcula cuántos bitcoins recibes a 50000€/BTC, descontando la comisión. Muestra: "Inviertes {monto}€ → recibes {bitcoins} BTC (comisión: {comision}€)".

---

### Bloque VI: Conversiones de Tipo (Ejercicios 31-35)

**Ejercicio 31: Conversión con Pérdida de Datos**
Crea un archivo `ej31.cs` que declare `double precio = 19.99;` y lo convierta a `int` con `(int)precio`. Muestra ambos valores. Explica por qué pierdes los decimales y en qué situaciones podría ser útil (ej: mostrar solo la parte entera de un precio).

**Ejercicio 32: Parse vs TryParse en un Login**
Crea un archivo `ej32.cs` que pida al usuario su "ID de jugador" (número). Intenta convertirlo con `int.Parse()` en un bloque `try-catch`. Luego haz lo mismo con `int.TryParse()` sin `try-catch`. Compara ambos enfoques.

**Ejercicio 33: Convert.ToInt32 vs int.Parse**
Crea un archivo `ej33.cs` que demuestre la diferencia: `Convert.ToInt32("123")`, `int.Parse("123")`, `Convert.ToInt32("")` (lanza excepción), `int.TryParse("abc", out var res)` (devuelve false). Muestra el resultado de cada uno.

**Ejercicio 34: Booleano a Texto para un Chat**
Crea un archivo `ej34.cs` que declare `bool enLinea = true;` y lo convierta a `string` con `.ToString()`. Concatena con un mensaje: "{usuario} está {enLinea}". Luego muestra lo mismo con un ternario: "en línea" o "desconectado".

**Ejercicio 35: Precio Seguro desde Input**
Crea un archivo `ej35.cs` que pida al usuario el precio de una compra. Usa `decimal.TryParse()` para convertirlo. Si es válido, muestra "Compra registrada: {precio}€". Si no, muestra "Error: introduces un precio no válido".

---

### Bloque VII: Operadores Lógicos y Ternario (Ejercicios 36-42)

**Ejercicio 36: ¿Puede Entrar al Premium?**
Crea un archivo `ej36.cs` con `bool esSuscriptor = true;` `bool tieneEdad = true;`. El usuario puede acceder al contenido premium SOLO si es suscriptor Y tiene edad suficiente. Usa `&&` y muestra el resultado.

**Ejercicio 37: Notificación Push**
Crea un archivo `ej37.cs` con `bool tieneNotificaciones = false;`. Si NO tiene notificaciones activadas, muestra "Activa las notificaciones para no perderte nada". Usa el operador `!`.

**Ejercicio 38: Filtro de Contenido**
Crea un archivo `ej38.cs` que pida la edad al usuario. Muestra si es menor de 13 O mayor de 18,indicando que cierto contenido no le está disponible.

**Ejercicio 39: Clasificador de Pokémon por Peso**
Crea un archivo `ej39.cs` que pida el peso de un Pokémon (decimal). Usa un ternario: si pesa menos de 10 kg es "Ligero", si pesa entre 10 y 100 es "Mediano", si pesa más de 100 es "Pesado".

**Ejercicio 40: Nota de una Review**
Crea un archivo `ej40.cs` que pida una nota del 1 al 10. Usa un ternario anidado para mostrar: "Malo" (<4), "Regular" (4-6), "Bueno" (7-8), "Excelente" (9-10).

**Ejercicio 41: Precedencia Lógica en un IF**
Crea un archivo `ej41.cs` con `bool c1 = true, c2 = false, c3 = true;`. Evalúa `!c1 || c2 && c3` y muestra el resultado. Explica en un comentario que `&&` tiene prioridad sobre `||`.

**Ejercicio 42: Expresión Lógica Compleja**
Crea un archivo `ej42.cs` que evalúe `!(true && false) || (true || false)`. Descompón la expresión paso a paso en comentarios y muestra el resultado final.

---

### Bloque VIII: Manejo de Nulos y Coalescencia (Ejercicios 43-45)

**Ejercicio 43: Avatar por Defecto**
Crea un archivo `ej43.cs` con `string? avatar = null;`. Si el usuario no tiene avatar asignado, usa `?? "avatar_predeterminado.png"` para asignar uno por defecto. Muestra el resultado.

**Ejercicio 44: Puntuación Vacía**
Crea un archivo `ej44.cs` con `int? puntuacion = null;` (simulando que un jugador aún no ha puntuado). Usa `??` para asignar 0 si es null. Luego verifica si la puntuación es par o impar.

**Ejercicio 45: Mensaje de Error Seguro**
Crea un archivo `ej45.cs` con `string? mensajeError = null;`. Usa `?? "Sin errores"` para mostrar un mensaje por defecto. Luego prueba con `mensajeError = "Archivo no encontrado"` y muestra el mensaje real.

---

### Bloque IX: Enums Avanzados y Lógica (Ejercicios 46-48)

**Ejercicio 46: Tipo de Pokémon con Método**
Crea un archivo `ej46.cs` que defina `enum TipoPokemon { Fuego, Agua, Planta, Electrico }`. Escribe una función que reciba un `TipoPokemon` y devuelva un string: "Fuego es débil contra Agua, fuerte contra Planta". Declara una variable y muestra la descripción.

**Ejercicio 47: Validación de Partida**
Crea un archivo `ej47.cs` con `double ping = 45.0;` `int jugadores = 8;` `bool servidorActivo = true;`. Una partida es "válida" si: ping < 100 Y jugadores >= 2 Y servidorActivo es true. Muestra el resultado.

**Ejercicio 48: Nota Media de un Módulo**
Crea un archivo `ej48.cs` con `const double PESO_TEORIA = 0.40, PESO_PRACTICA = 0.60;`. Pide las notas de teoría y práctica. Calcula la nota media ponderada. Muestra si ha aprobado (>=5).

---

### Bloque X: De Morgan y Desafíos Finales (Ejercicios 49-50)

**Ejercicio 49: De Morgan en un Ranking**
Crea un archivo `ej49.cs` con `int nivel = 150;` `int oro = 5000;`. Un jugador está en "Top 100" si `nivel > 200 && oro > 10000`. Expresa la condición de que NO está en Top 100 usando De Morgan: `!(A && B) == !A || !B`. Muestra ambos resultados.

**Ejercicio 50: De Morgan en un Ban**
Crea un archivo `ej50.cs` con `bool reportado = false;` `bool advertido = false;`. Un usuario es "baneado" si `reportado || advertido`. Expresa la condición de que NO es baneado usando De Morgan: `!(A || B) == !A && !B`. Muestra ambos resultados.
