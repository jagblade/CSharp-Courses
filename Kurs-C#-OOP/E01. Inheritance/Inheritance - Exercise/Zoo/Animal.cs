namespace Zoo
{
    public abstract class Animal
    {
        private string name;
        protected Animal(string name)
        {
            this.name = name;
        }

        public string Name { get; private set; }
    }
}
