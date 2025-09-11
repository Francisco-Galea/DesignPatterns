using FactoryMethod.Interface;

namespace FactoryMethod.Classes
{
    public class Bicycle : IVehicle
    {
        public string brand { get; private set; }
        public string model { get; private set; }

        public Bicycle(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public void Start()
        {
            Console.WriteLine($"La {brand} {model} se impulsa pedaleando");
        }

        public void Stop()
        {
            Console.WriteLine($"La {brand} {model} se detiene con frenos de cable");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Bicicleta: {brand} {model} - 2 ruedas, propulsión humana");
        }
    }
}
