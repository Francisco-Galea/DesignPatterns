namespace Singleton
{
    /// <summary>
    /// LogManager implementa el patrón Singleton garantizando una única instancia.
    ///
    /// Opciones de inicialización:
    /// 1) Inicialización estática (ansiosa/eager) – implementada abajo
    ///    - Cómo funciona: el CLR inicializa los campos static readonly de forma thread-safe
    ///      cuando el tipo se carga por primera vez en el AppDomain.
    ///    - Pros:
    ///        * Simplicidad máxima
    ///        * Thread-safe sin locks ni costes extra
    ///        * Muy predecible
    ///    - Contras:
    ///        * La instancia se crea aunque nunca se use (no es "lazy")
    ///    - Cuándo usarla:
    ///        * El costo de construir la instancia es bajo o aceptable al inicio
    ///        * Quieres el ejemplo más claro y robusto
    ///
    /// 2) Inicialización diferida (lazy) con Lazy<T> – alternativa comentada más abajo
    ///    - Cómo funciona: la instancia se crea la primera vez que se accede a Instance;
    ///      Lazy<T> es thread-safe por defecto (ExecutionAndPublication).
    ///    - Pros:
    ///        * Creación bajo demanda
    ///        * Thread-safe sin implementar locking manual
    ///    - Contras:
    ///        * Ligero overhead de Lazy (normalmente insignificante)
    ///    - Cuándo usarla:
    ///        * La construcción es costosa y podría no ser necesaria en todos los escenarios
    ///        * Quieres lazy real con semántica clara
    /// </summary>
    public sealed class LogManager
    {
        // Opción 1: Inicialización estática (ansiosa), thread-safe sin locks
        private static readonly LogManager instance = new LogManager();
        public static LogManager Instance => instance;

        private LogManager() { }

        /// <summary>
        /// Registra un mensaje con marca temporal simple.
        /// </summary>
        public void Log(string message)
        {
            var timestamp = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine($"[{timestamp}] {message}");
        }

        /*
        // Opción 2: Inicialización diferida (lazy) con Lazy<T> (DESCOMENTAR SI LA QUIERES USAR)
        // Reemplaza los miembros anteriores por estos:

        private static readonly Lazy<LogManager> lazyInstance =
            new Lazy<LogManager>(() => new LogManager()); // Thread-safe por defecto

        public static LogManager Instance => lazyInstance.Value;

        private LogManager() { }
        */
    }
}