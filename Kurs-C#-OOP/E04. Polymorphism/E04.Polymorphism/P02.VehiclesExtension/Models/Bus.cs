namespace P02.VehiclesExtension.Models
{
    public class Bus : Vehicle
    {

        public Bus(double fuelQuantity, double fuelConsumption,double tankCapacity) : base(fuelQuantity, fuelConsumption,tankCapacity)
        {

        }

        public override string Drive(double distance, double busAirConConst)
        {
            FuelConsumption += busAirConConst;

            return Drive(distance);
        }
    }
}
