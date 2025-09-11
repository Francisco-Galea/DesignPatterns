using FactoryMethod.Interface;

namespace FactoryMethod.Classes
{
    /// <summary>
    /// Representa una motocicleta que implementa el contrato IVehicle.
    /// Demuestra polimorfismo: puede ser tratada como IVehicle manteniendo su comportamiento específico.
    /// </summary>
    /// <remarks>
    /// Ejemplo de uso polimórfico: IVehicle vehiculo = new Motorcycle();
    /// </remarks>
    public class Motorcycle : IVehicle
    {
        public string brand { get; private set; }
        public string model { get; private set; }

        public Motorcycle(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public void Start()
        {
            Console.WriteLine($"La {brand} {model} arranca presionando el botón de encendido");
        }

        public void Stop()
        {
            Console.WriteLine($"La {brand} {model} se detiene con freno de mano y pie");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Motocicleta: {brand} {model} - 2 ruedas, alta velocidad");
        }
    }
}
