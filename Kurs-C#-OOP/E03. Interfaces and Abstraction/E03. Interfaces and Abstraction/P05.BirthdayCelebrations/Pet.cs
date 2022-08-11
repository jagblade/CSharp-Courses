
namespace P05.BirthdayCelebrations
{
    using System;

    public class Pet : IBirthDate
    {
        private string name;
        public Pet(string name, DateTime birthDate)
        {
            this.name = name;
            this.BirthDate = birthDate;
        }
        public DateTime BirthDate {get; private set;}
    }
}
