namespace P05.BirthdayCelebrations
{
    using System;

    public class Citizen : IIdNumerable, IBirthDate
    {


        private string name;
        private int age;

        public Citizen(string name, int age, string id,DateTime birthday)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.BirthDate = birthday;
        }

        public string Id { get; private set; }

        public DateTime BirthDate { get; private set; } 


    }
}
