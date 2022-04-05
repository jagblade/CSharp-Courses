using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var listProduct = new Dictionary<string, double[]>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                string[] inputProduct = input.Split().ToArray();
                string product = inputProduct[0];
                double price = double.Parse(inputProduct[1], CultureInfo.InvariantCulture);
                double quantity = double.Parse(inputProduct[2], CultureInfo.InvariantCulture);
                if (!listProduct.ContainsKey(product))
                {
                    listProduct.Add(product, new double[2]);
                }
                listProduct[product][0] = price;
                listProduct[product][1] += quantity;
            }
            foreach (var item in listProduct)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}