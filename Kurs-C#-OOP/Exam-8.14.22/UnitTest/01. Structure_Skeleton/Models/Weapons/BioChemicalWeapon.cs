namespace PlanetWars.Models.Weapons
{
    using Models;
    internal class BioChemicalWeapon : Weapon, MilitaryUnit
    {
        private const double bioChemPrice = 3.2;
        public BioChemicalWeapon(int destructionLevel) : base(destructionLevel, bioChemPrice)
        {
        }
    }
}
