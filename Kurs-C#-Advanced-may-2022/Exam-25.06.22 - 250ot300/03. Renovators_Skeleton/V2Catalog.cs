using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        private string name;
        private int neededRenovators;
        private string project;

        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>();
        }

        public int Count => Renovators.Count;

        public string AddRenovator(Renovator renovator)
        {
            if (renovator.Name == null || renovator.Name == string.Empty || renovator.Type == null || renovator.Type == string.Empty)
            {
                return "Invalid renovator's information.";
            }
            //!
            else if (!(Renovators.Count < NeededRenovators))
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            //!
            Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            if (Renovators.Any(x => x.Name == name))
            {
                Renovators.RemoveAll(x => x.Name == name);
                return true;
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            if (Renovators.Any(x => x.Type == type))
            {
                int count = Renovators.Count;
                Renovators.RemoveAll(x => x.Type == type);
                return count - Renovators.Count;
            }

            return 0;
        }

        public Renovator HireRenovator(string name)
        {
            Renovator currRenovator = null;
            foreach (var renovator in Renovators)
            {
                if (renovator.Name == name)
                {
                    renovator.Hired = true;
                    currRenovator = renovator;
                }
            }
            return currRenovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            return new List<Renovator>(Renovators.Where(x => x.Days >= days));
        }

        public string Report()
        {
            var renovats = this.Renovators.Where(x => x.Hired == false);
            return $"Renovators available for Project {project}:" + Environment.NewLine + string.Join(Environment.NewLine, renovats);
        }




        public List<Renovator> Renovators
        {
            get => renovators;
            set => renovators = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int NeededRenovators
        {
            get => neededRenovators;
            set => neededRenovators = value;
        }
        public string Project
        {
            get => project;
            set => project = value;
        }



    }
}
