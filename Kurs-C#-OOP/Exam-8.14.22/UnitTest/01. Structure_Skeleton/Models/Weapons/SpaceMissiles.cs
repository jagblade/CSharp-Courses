namespace PlanetWars.Models.Weapons
{
    using Models;
    internal class SpaceMissiles : Weapon
    {
        private const double SpaceMisslesPrice = 8.75;
        public SpaceMissiles(int destructionLevel, double price) : base(destructionLevel, SpaceMisslesPrice)
        {
        }
    }
}
