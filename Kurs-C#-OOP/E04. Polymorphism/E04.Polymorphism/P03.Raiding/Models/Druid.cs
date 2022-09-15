namespace P03.Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name)
            : base(name)
        {
            this.Power = (int)HerosPowers.Druid;
        }

        public override int Power { get => base.Power; protected set => base.Power = value; }
    }
}