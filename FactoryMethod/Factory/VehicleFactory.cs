using FactoryMethod.Classes;
using FactoryMethod.Enum;
using FactoryMethod.Interface;

namespace FactoryMethod.Factory
{
    public class VehicleFactory
    {
        /// <summary>
        /// Para evitar el uso de multiples return dentro del switch, creo un objeto IVehicle vehicle, 
        /// para que luego, dentro de cada una de las opciones del switch, asignarle el valor del objeto creado.
        /// Ejemplo: Si voy a crear un auto, ejecuto case de VehicleType.Car, creo el objeto IVehicle de tipo Car,
        /// y lo asigno en la variable vehicle.
        /// </summary>
        /// <param name="vehicleType">
        /// Gracias al enum, evitamos comparar con strings, y que el usuario
        /// ingrese un tipo de vehiculo que no exista.                            
        /// </param>
        /// <param name="brand">
        /// la marca del vehiculo
        /// </param>
        /// <param name="model">
        /// modelo del vehiculo
        /// </param>
        /// <returns>
        /// Devuelvo el objeto vehicle de tipo IVehicle, puede ser cualquiera, auto, moto, bicicleta.
        /// </returns>
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
