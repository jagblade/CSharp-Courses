namespace P02.VehiclesExtension.Models
{
    using Interfaces;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        protected Vehicle(double fuelQuantity, double fuelConsumption,double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity 
        {
            get 
            {
                return this.fuelQuantity;
             }
                
            private set

            {
                if (value > this.tankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value; }
            }
        }
        public double FuelConsumption {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {
                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            protected set
            {
                this.tankCapacity = value;
            }
        }
        public string Drive(double distance)
        {
            double fuelNeeded = distance * this.fuelConsumption;

            if (fuelNeeded > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";

            }

            this.FuelQuantity -= fuelNeeded;

            return $"{this.GetType().Name} travelled {distance} km";

        }

        public virtual string Drive(double distance, double airConcoef) 
        {
            return Drive(distance);
        }
        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                System.Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (this.tankCapacity < this.fuelQuantity + liters)
                {
                    System.Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += liters;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
