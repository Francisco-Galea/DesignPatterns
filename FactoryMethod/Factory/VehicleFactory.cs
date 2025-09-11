using FactoryMethod.Classes;
using FactoryMethod.Enum;
using FactoryMethod.Interface;

namespace FactoryMethod.Factory
{
    public class VehicleFactory
    {
        public static IVehicle CreateVehicle(VehicleType vehicleType, string brand, string model)
        {
            IVehicle vehicle = null;
            switch (vehicleType) 
            {
                case VehicleType.Car:
                    IVehicle car = new Car(brand, model);
                    vehicle = car;
                    break;

                case VehicleType.Bicycle:
                    IVehicle bicycle = new Bicycle(brand, model);
                    vehicle = bicycle;
                    break;

                case VehicleType.Motorcycle:
                    IVehicle motorcycle = new Bicycle(brand, model);
                    vehicle = motorcycle;
                    break;
            }
            return vehicle;
        }
    }
}
