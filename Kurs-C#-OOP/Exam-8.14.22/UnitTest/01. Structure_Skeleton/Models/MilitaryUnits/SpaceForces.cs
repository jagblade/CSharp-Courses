namespace PlanetWars.Models.MilitaryUnits
{
    using Models;
    internal class SpaceForces : MilitaryUnit
    {
        private const double spaceForceCost = 11;
        public SpaceForces() : base(spaceForceCost)
        {
        }
    }
}
