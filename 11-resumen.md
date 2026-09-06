- [11. Resumen de la Unidad](#11-resumen-de-la-unidad)
  - [11.1. Mapa conceptual](#111-mapa-conceptual)
  - [11.2. Checklist de supervivencia](#112-checklist-de-supervivencia)
  - [11.3. Errores comunes a evitar](#113-errores-comunes-a-evitar)
  - [11.4. Lo que hemos aprendido](#114-lo-que-hemos-aprendido)


# 11. Resumen de la Unidad

> 💡 **Punto de partida:** Llevas toda la unidad aprendiendo conceptos. Ahora es el momento de ordenar todo en tu cabeza. ¿Qué te llevas de aquí?

## 11.1. Mapa conceptual

```mermaid
graph TB
    A[Introduccion a la Programacion] --> B[Fundamentos]
    A --> C[Lenguajes]
    A --> D[Entorno .NET]
    A --> E[Elementos del Programa]

    B --> B1[Que es programar]
    B --> B2[Algoritmos y caracteristicas]
    B --> B3[Paradigmas]

    C --> C1[Lectico, Sintaxis, Semantica]
    C --> C2[Clasificacion de lenguajes]

    D --> D1[SDK y CLI]
    D --> D2[NuGet]
    D --> D3[IDEs]

    E --> E1[Tipos de datos]
    E --> E2[Variables y constantes]
    E --> E3[Operadores]
    E --> E4[Conversiones]
    E --> E5[Entrada y salida]
    E --> E6[Comentarios]

    style A fill:#2196F3,color:#fff
    style B fill:#4CAF50,color:#fff
    style C fill:#FF9800,color:#fff
    style D fill:#9C27B0,color:#fff
    style E fill:#f44336,color:#fff
```

## 11.2. Checklist de supervivencia

Comprueba si dominas estos puntos antes de pasar a la siguiente unidad:

- [ ] Sé explicar qué es un programa y qué es un algoritmo
- [ ] Conozco las 6 características de un algoritmo (finito, definido, preciso, entrada, salida, efectividad)
- [ ] Sé la diferencia entre léxico, sintaxis y semántica
- [ ] Sé crear una solución y un proyecto con la CLI (`dotnet new sln`, `dotnet new console`)
- [ ] Entiendo la diferencia entre `.slnx` y `.csproj`
- [ ] Sé usar Top-Level Statements en C# 14
- [ ] Conozco los tipos de datos: `int`, `long`, `float`, `double`, `decimal`, `bool`, `char`, `string`
- [ ] Sé la diferencia entre enteros con signo y sin signo
- [ ] Sé declarar variables y constantes
- [ ] Conozco los operadores aritméticos, relacionales, lógicos, de asignación, ternario y de coalescencia
- [ ] Sé la diferencia entre conversión implícita y explícita
- [ ] Sé usar `Console.WriteLine` y `Console.ReadLine`
- [ ] Conozco la interpolación de strings con `$""`
- [ ] Sé escribir comentarios de una línea, varias líneas y documentación XML
- [ ] Entiendo qué es `using static` y para qué sirve

## 11.3. Errores comunes a evitar

| Error | Por qué está mal | Cómo evitarlo |
|-------|------------------|---------------|
| Olvidar `;` al final | C# es estricto con punto y coma | Revisar cada línea |
| Confundir `=` y `==` | `=` es asignación, `==` es comparación | Usar `==` en condiciones |
| División entre enteros | `10/3` da `3`, no `3.33` | Convertir a `double` antes: `(double)10/3` |
| No inicializar variables | Puede dar error al usarlas | Siempre asignar un valor al declarar |
| Usar `Parse` sin validar | Si el usuario no mete un número, salta excepción | Usar `TryParse` |
| Confundir `Write` y `WriteLine` | `Write` no salta de línea | `WriteLine` para nueva línea |

## 11.4. Lo que hemos aprendido

| Tema | Lo más importante |
|------|-------------------|
| **Fundamentos** | Programar es resolver problemas con instrucciones precisas |
| **Algoritmos** | Plan ordenado con 6 características: finito, definido, preciso, entrada, salida, efectividad |
| **Entorno .NET** | SDK, CLI, NuGet, IDE (Rider recomendado) |
| **Soluciones y proyectos** | `.slnx` agrupa proyectos, `.csproj` configura uno |
| **Estructura** | Top-Level Statements para empezar fácil |
| **Tipos de datos** | `int` por defecto, `decimal` para dinero, `string` para texto |
| **Variables** | camelCase, siempre inicializar |
| **Constantes** | `const`, nunca cambian, PascalCase |
| **Operadores** | Aritméticos, relacionales, lógicos, ternario `? :`, coalescencia `??` |
| **Conversiones** | Implícita (segura), explícita (casting), `TryParse` (seguro) |
| **Entrada/Salida** | `WriteLine`, interpolación `$""`, `ReadLine` |
| **Comentarios** | `//` una línea, `/* */` varias, `///` documentación XML |

> 💡 **Consejo para el examen:** Repasa el checklist. Si marcas todos los puntos, estás listo para el examen de esta unidad. Si falta alguno, revisa el tema correspondiente.

### Preguntas tipo test para repasar

Antes de ir al examen, asegúrate de poder responder **SÍ** a estas preguntas:

| Pregunta | Tema |
|----------|------|
| ¿Entiendo que un programa es una solución a un problema y no solo código? | 1.1 |
| ¿Sé la diferencia entre un algoritmo y un programa? | 1.5 |
| ¿Recuerdo las 6 características de un algoritmo? | 1.2.1 |
| ¿Sé explicar la diferencia entre compilado e interpretado? | 1.4 |
| ¿Diferencio entre léxico, sintaxis y semántica? | 1.4 |
| ¿Entiendo la diferencia entre `int` y `double` (y por qué no usar `int` para dinero)? | 5 |
| ¿Tengo claro que `var` no significa que el tipo pueda cambiar luego? | 5 |
| ¿Entiendo que `null` es un peligro y que `?` me ayuda a controlarlo? | 5 |
| ¿Sé por qué `(5 + 2) * 3` no es lo mismo que `5 + 2 * 3`? | 7 |
| ¿Recuerdo que `ReadLine()` siempre me da un `string` y debo convertirlo? | 9 |
| ¿Sé usar `TryParse` en vez de `Parse` para entrada de usuario? | 9 |

> 🔧 **Truco:** Si no puedes responder alguna pregunta, abre el tema correspondiente y repásalo. La clave es **entender**, no memorizar.

> 🔧 **Truco:** La mejor forma de aprender programación es practicando. No leas solo los apuntes: abre el IDE y prueba cada ejemplo. Modifícalos, rompelos, arreglalos. Eso es como se aprende.
