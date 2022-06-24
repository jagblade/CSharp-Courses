using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    internal class Family
    {
        private List<Person> family = new List<Person>();

        public void AddMember(Person member)
        {
            this.family.Add(member);
        }

        public Person GetOledestMember()
        {
            return this.family.OrderByDescending(m => m.Age).First();
        }
    }
}
