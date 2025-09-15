# 🧩 Singleton

## 📖 Teoría
El **Singleton** es un patrón de diseño **creacional** que garantiza que exista **una única instancia** de una clase en toda la aplicación y proporciona un **punto de acceso global** a la misma.

- ✔️ Controla el acceso a un único recurso compartido.  
- ✔️ Puede ser de inicialización ansiosa (estática) o diferida (lazy).  
- ✔️ Útil para configuraciones globales, logging o caches simples.  
- ⚠️ Puede dificultar pruebas si se abusa.  
- ⚠️ Puede introducir estado global y acoplamiento implícito.

## 🎯 Objetivo del ejemplo
Mostrar cómo crear y acceder a una única instancia de un administrador de logs `LogManager`, comprobar que dos referencias apuntan a la **misma** instancia, y ejecutar un método que registre mensajes.

## 🛠️ Implementaciones posibles

### 1) Inicialización estática (ansiosa) — usada por defecto en este proyecto
- El CLR inicializa los campos `static readonly` de forma thread‑safe al cargar el tipo.
- **Pros**: simplicidad, zero locks, muy predecible.
- **Contras**: no es lazy; se crea aunque no se use.

```csharp
public sealed class LogManager
{
    private static readonly LogManager instance = new LogManager();
    public static LogManager Instance => instance;
    private LogManager() { }
    public void Log(string message) { /* ... */ }
}
```

### 2) Inicialización diferida (lazy) con `Lazy<T>`
- La instancia se crea al primer acceso, también thread‑safe sin locks manuales.
- **Pros**: creación bajo demanda.
- **Contras**: ligero overhead de `Lazy<T>` (normalmente irrelevante).

```csharp
private static readonly Lazy<LogManager> instance =
    new(() => new LogManager());
public static LogManager Instance => instance.Value;
```

## 🧪 Uso (ver `Program.cs`)
- Obtener la instancia: `var logger = LogManager.Instance;`
- Registrar mensajes: `logger.Log("mensaje");`
- Verificar identidad: `ReferenceEquals(loggerA, loggerB)` devuelve `true`.

## 📊 Diagramas (UML)
El archivo `Singleton.png` ilustra el patrón para ambas variantes. En ambos casos, `Instance` es una propiedad estática que expone la única instancia. La seguridad de hilos la proporciona el CLR (versión estática) o `Lazy<T>` (versión lazy).
