namespace PlanetWars.Models
{
    using MilitaryUnits.Contracts;
    using System;
    using Utilities.Messages;

    internal class MilitaryUnit : IMilitaryUnit
    {
        private const int initialEndurance = 1;

        public MilitaryUnit(double cost)
        {
            this.Cost = cost;
            this.EnduranceLevel = initialEndurance;
        }
        public double Cost {get; private set;}

        public int EnduranceLevel 
        {

            get
            { 
                return this.EnduranceLevel; 
            }
            set
            { 
                this.EnduranceLevel = initialEndurance;
            }
        }

        public void IncreaseEndurance()
        {

            if (this.EnduranceLevel >= 20)
            {
                this.EnduranceLevel = 20;
                throw new ArgumentException(ExceptionMessages.EnduranceLevelExceeded);
            }
            EnduranceLevel++;
        }
    }
}
