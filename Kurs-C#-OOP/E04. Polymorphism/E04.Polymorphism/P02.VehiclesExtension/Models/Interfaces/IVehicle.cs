namespace P02.VehiclesExtension.Models.Interfaces
{
    internal interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double TankCapacity { get; }
        string Drive(double distance);
            
        void Refuel(double liters);



    }
}
