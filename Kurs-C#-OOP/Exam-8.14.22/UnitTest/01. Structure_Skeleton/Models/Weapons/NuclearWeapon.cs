namespace PlanetWars.Models.Weapons
{
    using Models;
    internal class NuclearWeapon : Weapon
    {
        private const double nuclearPrice = 15;
        public NuclearWeapon(int destructionLevel) : base(destructionLevel, nuclearPrice)
        {
        }
    }
}
