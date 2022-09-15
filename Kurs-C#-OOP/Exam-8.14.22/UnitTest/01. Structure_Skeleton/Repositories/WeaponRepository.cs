namespace PlanetWars.Repositories
{
    using Contracts;
    using Models;
    using System.Collections.Generic;

    internal class WeaponRepository : IRepository<Weapon>
    {
        public System.Collections.Generic.IReadOnlyCollection<Weapon> Models => throw new System.NotImplementedException();

        IReadOnlyCollection<Weapon> IRepository<Weapon>.Models => throw new System.NotImplementedException();

        public void AddItem(Weapon model)
        {
            throw new System.NotImplementedException();
        }

        public Weapon FindByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveItem(string name)
        {
            throw new System.NotImplementedException();
        }

        Weapon IRepository<Weapon>.FindByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
