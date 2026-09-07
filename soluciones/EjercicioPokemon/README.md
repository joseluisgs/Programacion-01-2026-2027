# Ejercicio Pokémon — UD01

## Objetivo

Crear un programa en C# que simule una **Pokédex** donde el usuario introduce datos de un Pokémon y el programa muestra una ficha completa con cálculos.

**Conceptos aplicados:**
- Tipos de datos (`string`, `int`, `double`, `bool`)
- Variables y constantes (`const`)
- Operadores aritméticos (`*`, `/`, `+`, `-`)
- Operadores relacionales (`>=`, `<=`, `==`)
- Operadores lógicos (`&&`)
- Operador ternario (`? :`)
- Coalescencia nula (`??`, `??=`)
- Conversiones de tipo (`int.TryParse`, `double.TryParse`, `(int)`)
- Entrada/salida (`Console.ReadLine`, `Console.WriteLine`)
- Interpolación de strings (`$"..."`)

## Comandos utilizados

### 1. Crear la carpeta de la solución

```bash
mkdir EjercicioPokemon
cd EjercicioPokemon
```

### 2. Crear la solución (.slnx)

```bash
dotnet new sln --name EjercicioPokemon
```

### 3. Crear el proyecto de consola

```bash
dotnet new console --name EjercicioPokemon
```

### 4. Añadir el proyecto a la solución

```bash
dotnet sln add EjercicioPokemon/EjercicioPokemon.csproj
```

### 5. Verificar la estructura

```bash
dotnet sln list
```

Salida esperada:
```
Proyectos en la solución EjercicioPokemon:
  EjercicioPokemon/EjercicioPokemon.csproj
```

### 6. Compilar

```bash
dotnet build
```

### 7. Ejecutar

```bash
dotnet run
```

### 8. Verificar que no hay errores

```bash
dotnet build --no-restore
```

## Estructura del proyecto

```
EjercicioPokemon/
├── EjercicioPokemon.slnx
└── EjercicioPokemon/
    ├── EjercicioPokemon.csproj
    └── Program.cs
```

## Ejemplo de ejecución

```
╔══════════════════════════════════════════╗
║   🎮 POKÉDEX v1.0 — UD01 Programación   ║
║   Crea tu propia ficha de Pokémon        ║
╚══════════════════════════════════════════╝

¿Cómo te llamas, Entrenador? Ash
¡Hola, Ash! Vamos a crear tu ficha Pokémon.

Nombre del Pokémon: Charizard
Tipo (Fuego, Agua, Planta, Eléctrico, etc.): Fuego
CP (Combat Power, número entero): 2500
Nivel (1-100): 45
¿Es legendario? (s/n): n
Altura en metros (ej: 1.7): 1.7

╔══════════════════════════════════════════╗
║           FICHA DEL POKÉMON              ║
╠══════════════════════════════════════════╣
║  Nombre:      🔥 Charizard               ║
║  Tipo:        Fuego                      ║
║  CP:          2500                       ║
║  Nivel:       45                         ║
║  Altura:      1.70 m (170 cm)           ║
║  Rareza:      COMÚN                      ║
║  Estado CP:   MÁXIMO                     ║
║  Poder est.:  340                        ║
║  ¿Poderoso?  SÍ                          ║
╠══════════════════════════════════════════╣
║  CP con bonus legendario: 3750.0         ║
║  Entrenador: Ash                         ║
╚══════════════════════════════════════════╝

¡Buen Pokémon, Ash! Con el tiempo será aún más fuerte.

Gracias por usar la Pokédex v1.0
```
