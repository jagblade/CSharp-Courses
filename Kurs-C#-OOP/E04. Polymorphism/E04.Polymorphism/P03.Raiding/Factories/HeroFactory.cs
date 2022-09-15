using System;

namespace P03.Raiding.Factories
{
    public class HeroFactory
    {
        public BaseHero ProduceHero(string name, string type)
        {
            BaseHero hero = null;

            if (type == HeroType.Druid.ToString())
            {
                hero = new Druid(name);
            }
            else if (type == HeroType.Paladin.ToString())
            {
                hero = new Paladin(name);
            }
            else if (type == HeroType.Rogue.ToString())
            {
                hero = new Rogue(name);
            }
            else if (type == HeroType.Warrior.ToString())
            {
                hero = new Warrior(name);
            }
            else if (hero == null)
            {
                throw new ArgumentException("Invalid hero!");

            }

            return hero;
        }
    }
}