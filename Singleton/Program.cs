using Singleton;

// Acceso a la instancia única (implementación por defecto: inicialización estática sin locks)
// Alternativa didáctica: usar Lazy<T> en LogManager si se desea "lazy" real.
var loggerA = LogManager.Instance;
var loggerB = LogManager.Instance;

Console.WriteLine("\n--- Probando Singleton (LogManager) ---");
loggerA.Log("Iniciando la aplicación");
loggerB.Log("Cargando configuración");

// Comprobación: ambas referencias apuntan a la misma instancia
Console.WriteLine($"\n¿loggerA y loggerB son la misma instancia? {ReferenceEquals(loggerA, loggerB)}");

// Uso de un método de ejemplo
loggerA.Log("Operación completada correctamente");