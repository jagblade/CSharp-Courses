namespace PlanetWars.Models.MilitaryUnits
{
    using Models;

    internal class AnonymousImpactUnit : MilitaryUnit
    {
        private const double AnonymousImpactUnitCost = 30;

        public AnonymousImpactUnit() : base(AnonymousImpactUnitCost)
        {
        }
    }
}
