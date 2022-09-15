using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private readonly ICollection<Fish> fish;

        public IReadOnlyCollection<Fish> Fish => (IReadOnlyCollection<Fish>)fish;

        public Net(string material, int capacity)
        {
            this.fish = new List<Fish>();
            Material = material;
            Capacity = capacity;
        }

        public string Material { get; set; }
        public int Capacity { get; set; }

        public int Count => fish.Count;

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) ||
                fish.Length <= 0 ||
                fish.Weight <= 0)
            {
                return "Invalid fish.";
            }
            if (this.fish.Count >= Capacity)
            {
                return "Fishing net is full.";
            }
            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";

        }

        public bool ReleaseFish(double weight)
        {
            var exist = this.fish.FirstOrDefault(x => x.Weight == weight);

            if (exist != null)
            {
                return this.fish.Remove(exist);
            }
            return false;
        }

        public Fish GetFish(string fishType) { return this.fish.FirstOrDefault(x => x.FishType == fishType); }

        public Fish GetBiggestFish()
        {
         var maxLenght = this.fish.Max(x => x.Length);
         var fish = this.fish.FirstOrDefault(x => x.Length == maxLenght);
            return fish;
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Into the {this.Material}:");
            foreach (var f in Fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(f.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
