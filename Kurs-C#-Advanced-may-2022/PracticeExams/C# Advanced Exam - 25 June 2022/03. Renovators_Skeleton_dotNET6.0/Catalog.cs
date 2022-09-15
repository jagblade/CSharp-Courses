using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> RenovatorsList { get; set; }

        public IReadOnlyCollection<Renovator> Renovators => RenovatorsList;

        public string Name { get; set; }

        public int NeededRenovators { get; set; }

        public string Project { get; set; }

        public Catalog(string name, int neededRenovators, string project)
        {
            RenovatorsList = new List<Renovator>();

            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public int Count => RenovatorsList.Count;

        public string AddRenovator(Renovator renovator)
        {
            var nameOrSpecialtyInvalid = string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type) ? true : false;

            if (nameOrSpecialtyInvalid)
            {
                return "Invalid renovator's information.";
            }

            else if (RenovatorsList.Count == NeededRenovators)
            {
                return "Renovators are no more needed.";
            }

            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            RenovatorsList.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            var searchedRenovator = RenovatorsList.FirstOrDefault(worker => worker.Name == name);

            if (searchedRenovator != null)
            {
                return RenovatorsList.Remove(searchedRenovator);
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type) => RenovatorsList.RemoveAll(worker => worker.Type == type);

        public Renovator HireRenovator(string name)
        {
            var searchedRenovator = RenovatorsList.FirstOrDefault(worker => worker.Name == name);

            if (searchedRenovator != null)
            {
                RenovatorsList.Find(worker => worker.Name == name).Hired = true;

                searchedRenovator.Hired = true;

                return searchedRenovator;
            }
            return null;
        }

        public List<Renovator> PayRenovators(int days) => RenovatorsList.FindAll(worker => worker.Days >= days);

        public string Report()
        {
            var reportText = new StringBuilder();
            reportText.AppendLine($"Renovators available for Project {Project}:");

            reportText.AppendLine(string.Join(Environment.NewLine, RenovatorsList.FindAll(worker => worker.Hired == false)));

            return reportText.ToString().TrimEnd();
        }
    }
}