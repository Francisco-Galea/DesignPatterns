using FactoryMethod.Interface;

namespace FactoryMethod.Classes
{
    public class Car : IVehicle
    {
        public string brand { get; private set; }
        public string model { get; private set; }

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public void Start()
        {
            Console.WriteLine($"El {brand} {model} arranca girando la llave en el contacto");
        }

        public void Stop()
        {
            Console.WriteLine($"El {brand} {model} se detiene pisando el freno");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Coche: {brand} {model} - 4 ruedas, motor a combustión");
        }
    }
}
