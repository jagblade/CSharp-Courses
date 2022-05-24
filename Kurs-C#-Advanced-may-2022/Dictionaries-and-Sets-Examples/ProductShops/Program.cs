using System;
using System.Collections.Generic;
using System.Linq;

class ProductShops
{
    static void Main()
    {
        var prices = new Dictionary<string, Dictionary<string, double>>();
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "Revision")
            {
                PrintPrices(prices);
                break;
            }
            string[] tokens = line.Split(", ");
            string shop = tokens[0];
            string product = tokens[1];
            double price = double.Parse(tokens[2]);
            AddProduct(prices, shop, product, price);
        }
    }

    static void AddProduct(
        Dictionary<string, Dictionary<string, double>> prices,
        string shop, string product, double price)
    {
        if (!prices.ContainsKey(shop))
            prices.Add(shop, new Dictionary<string, double>());
        prices[shop][product] = price;
    }

    static void PrintPrices(
        Dictionary<string, Dictionary<string, double>> prices)
    {
        foreach (var shopAndProducts in prices.OrderBy(sp => sp.Key))
        {
            string shopName = shopAndProducts.Key;
            Console.WriteLine(shopName + "->");
            var products = shopAndProducts.Value;
            foreach (var productAndPrice in products)
            {
                Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value} ");
            }
        }
    }
}