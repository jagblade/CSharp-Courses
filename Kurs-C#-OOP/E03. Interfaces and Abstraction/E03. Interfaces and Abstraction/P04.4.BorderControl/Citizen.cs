﻿
namespace P04._4.BorderControl
{
    public class Citizen : IIdentifiable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
        }

        public string Id { get; private set; }
    }
}
