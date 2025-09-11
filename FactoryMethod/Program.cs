using FactoryMethod.Factory;
using FactoryMethod.Interface;
using FactoryMethod.Enum;

var vehicles = new List<IVehicle>
            {
                VehicleFactory.CreateVehicle(VehicleType.Car, "BMW", "X5"),
                VehicleFactory.CreateVehicle(VehicleType.Motorcycle, "Yamaha", "R1"),
                VehicleFactory.CreateVehicle(VehicleType.Bicycle, "Giant", "Escape"),
            };

foreach (var vehicle in vehicles)
{
    Console.WriteLine($"\n--- Probando vehículo ---");
    vehicle.GetInfo();
    vehicle.Start();
    vehicle.Stop();
}

