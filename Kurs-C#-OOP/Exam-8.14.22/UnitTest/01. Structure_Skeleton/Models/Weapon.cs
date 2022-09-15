namespace PlanetWars.Models
{
    using System;
    using Weapons.Contracts;
    using Utilities.Messages;
    internal class Weapon : IWeapon
    {
        private readonly double price;
        private readonly int destructionLevel;


        public Weapon(int destructionLevel, double price)
        {
            this.destructionLevel = destructionLevel;
            this.price = price;
        }
        public double Price {get; private set;}

        public int DestructionLevel {
            get => this.destructionLevel;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.TooLowDestructionLevel);
                }else if (value > 10)
                {
                    throw new ArgumentException(ExceptionMessages.TooHighDestructionLevel);
                }
                this.DestructionLevel = value;
            }
            }    }
}
