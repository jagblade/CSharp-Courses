namespace P02.VehiclesExtension.Models
{
    internal class Truck : Vehicle
    {
        private const double fuelConsumptionIncrement = 1.6;
        private const double refuelEfficiancy = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption,double tankCapacity) : 
            base(fuelQuantity, fuelConsumption + fuelConsumptionIncrement, tankCapacity )
        {
        }
        public override void Refuel(double liters)
        {
            base.Refuel(liters*refuelEfficiancy);
        }
    }
}
