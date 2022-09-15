namespace PlanetWars.Models
{
    using Planets.Contracts;
    using PlanetWars.Models.MilitaryUnits.Contracts;
    using PlanetWars.Models.Weapons.Contracts;
    using System.Collections.Generic;
    using Repositories;
    using System;
    using Utilities.Messages;

    internal class Planet : IPlanet
    {
        private UnitRepository units;
        private WeaponRepository weapons;
        public Planet()
        {
            
            this.units = new UnitRepository();
            this.weapons = new WeaponRepository();
        }
        public string Name
        {
            get { return this.Name; }
            private set {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                        throw new ArgumentException(ExceptionMessages.InvalidPlanetName);
                }
                
                
                this.Name = value; }
        }

        public double Budget
        {
            get { return this.Budget; }
            private set
            {
                if (value < 0 )
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBudgetAmount);
                }

                this.Budget = value;
            }
        }

        public double MilitaryPower => this.MilitaryPower;

        public IReadOnlyCollection<IMilitaryUnit> Army => this.Army;

        public IReadOnlyCollection<IWeapon> Weapons => this.Weapons;

        public void AddUnit(IMilitaryUnit unit)
        {
            this.AddUnit(unit);
        }

        public void AddWeapon(IWeapon weapon)
        {
           this.AddWeapon(weapon);
        }

        public string PlanetInfo()
        {
            throw new System.NotImplementedException();
        }

        public void Profit(double amount)
        {
            throw new System.NotImplementedException();
        }

        public void Spend(double amount)
        {
            throw new System.NotImplementedException();
        }

        public void TrainArmy()
        {
            throw new System.NotImplementedException();
        }
    }
}
