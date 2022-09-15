namespace PlanetWars.Models.MilitaryUnits
{
    using Models;
    internal class StormTroopers : MilitaryUnit
    {
        private const double sTroopersCost = 2.5;
        public StormTroopers() : base(sTroopersCost)
        {
        }
    }
}
