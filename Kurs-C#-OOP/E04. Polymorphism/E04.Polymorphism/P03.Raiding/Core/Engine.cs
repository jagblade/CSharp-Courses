using System;
using System.Linq;
using System.Collections.Generic;

using P03.Raiding.Factories;

namespace P03.Raiding.Core
{
    public class Engine
    {
        private HeroFactory heroFactory;

        public Engine()
        {
            this.heroFactory = new HeroFactory();
        }

        public void Run()
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int numberOfHeroes = int.Parse(Console.ReadLine());

            while (heroes.Count != numberOfHeroes)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    BaseHero hero = this.heroFactory.ProduceHero(name, type);
                    heroes.Add(hero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            int herosPowerSum = 0;

            if (heroes.Any())
            {
                foreach (var hero in heroes)
                {
                    Console.WriteLine(hero.CastAbility());
                    herosPowerSum += hero.Power;
                }

                if (herosPowerSum >= bossPower)
                {
                    Console.WriteLine("Victory!");
                }
                else
                {
                    Console.WriteLine("Defeat...");
                }
            }
        }
    }
}