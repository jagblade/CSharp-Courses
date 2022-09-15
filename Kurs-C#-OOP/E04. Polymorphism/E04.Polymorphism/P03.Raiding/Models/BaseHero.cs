namespace P03.Raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public virtual int Power { get; protected set; }

        public virtual string CastAbility()
        {
            if (this.GetType().Name == HeroType.Druid.ToString()
                || this.GetType().Name == HeroType.Paladin.ToString())
            {
                return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
            }

            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}