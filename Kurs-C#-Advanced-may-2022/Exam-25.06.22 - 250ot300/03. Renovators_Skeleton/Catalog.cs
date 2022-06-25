using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators = new List<Renovator>();

        //        •	Name: string
        //•	NeededRenovators: int
        //•	Project: string

        public string Name { get; set; }
        public int NeededRenovators { get; set; }

        public string Project { get; set; }

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
        }

        public int Count()
        {
            int result = renovators.Count();
            return result;
        }

        public string AddRenovator(Renovator renovator)
        {
            if (renovator == null)
            {
                return "Invalid renovator's information.";
            }
            else if (this.renovators.Count >= NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            else
            {
                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }


        }
        public bool RemoveRenovator(string name)
        {
            int count = this.renovators.RemoveAll(d => d.Name == name);

            return count > 0;

        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = this.renovators.RemoveAll(d => d.Type == type);

            return count;

        }

        public Renovator HireRenovator(string name)
        {
            Renovator exist = renovators.FirstOrDefault(d => d.Name == name);

            if (exist == null)
                return null;
            exist.Hired = true;
            return exist;
        }

        public List<Renovator> PayRenovators(int days)
        {
            if (true)
            {

            }
            List<Renovator> hired = this.renovators.Where(d => d.Days >= days).ToList();

            return hired;
        }

        public string Report()
        {
           
            var realtorsAvaliable = this.renovators.Where(d => d.Hired == false);
            return
                $"Renovators available for Project { this.Project}:" + Environment.NewLine +
                string.Join(Environment.NewLine, realtorsAvaliable);
        }
    }
}
