namespace P03.Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name)
            : base(name)
        {
            this.Power = (int)HerosPowers.Rogue;
        }

        public override int Power { get => base.Power; protected set => base.Power = value; }
    }
}