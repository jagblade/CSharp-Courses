namespace PlanetWars.Repositories
{
    using Contracts;
    using Models;
    using System.Collections.Generic;

    internal class PlanetRepository : IRepository<Planet>
    {
        public IReadOnlyCollection<Planet> Models => this.Models;

        public void AddItem(Planet model)
        {
            throw new System.NotImplementedException();
        }

        public Planet FindByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveItem(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
