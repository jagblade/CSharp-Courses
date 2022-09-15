namespace PlanetWars.Repositories
{
    using Contracts;
    using Models;
    using System.Collections.Generic;

    internal class UnitRepository : IRepository<MilitaryUnit>
    {
        public IReadOnlyCollection<MilitaryUnit> Models => throw new System.NotImplementedException();

        public void AddItem(MilitaryUnit model)
        {
            throw new System.NotImplementedException();
        }

        public MilitaryUnit FindByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveItem(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
