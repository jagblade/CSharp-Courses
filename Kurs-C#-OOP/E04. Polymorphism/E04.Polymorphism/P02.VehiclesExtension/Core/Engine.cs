namespace P02.VehiclesExtension.Core
{
    using Models;
    using System;

    internal class Engine : IEngine
    {
        private readonly Vehicle car;
        private readonly Vehicle truck;
        private readonly Vehicle bus;
        public Engine(Vehicle car,Vehicle truck,Vehicle bus)
        {
            this.car = car;
            this.truck = truck;
            this.bus = bus;
        }
        public void Start()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
            string[] cmd = Console.ReadLine().Split();

            string cmdType = cmd[0];
            string vehicleType = cmd[1];
            double cmdParam = double.Parse(cmd[2]);

                if (cmdType == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        Console.WriteLine(this.car.Drive(cmdParam));
                    }
                    else if (vehicleType == "Truck")
                    {
                        Console.WriteLine(this.truck.Drive(cmdParam));
                    }
                    else if (vehicleType == "Bus")
                    {
                        Console.WriteLine(this.bus.Drive(cmdParam));
                    }
                }
                else if (cmdType == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        this.car.Refuel(cmdParam);
                    }
                    else if (vehicleType == "Truck")
                    {
                        this.truck.Refuel(cmdParam);
                    }
                    else if (vehicleType == "Bus")
                    {
                        this.bus.Refuel(cmdParam);
                    }
                }
                else if (cmdType == "DriveEmpty" && vehicleType == "Bus")
                {
                    Console.WriteLine(this.bus.Drive(cmdParam, 1.4));
                }

            }
                Console.WriteLine(this.car);
                Console.WriteLine(this.truck);
                Console.WriteLine(this.bus);
        }
    }
}
