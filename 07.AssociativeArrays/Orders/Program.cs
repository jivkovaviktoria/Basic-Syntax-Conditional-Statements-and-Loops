using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> totalPrice = new Dictionary<string, double>();
            Dictionary<string, int> totalQuantity = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] tokens = input.Split(" ");

                string product = tokens[0];

                if (totalPrice.ContainsKey(product))
                {
                    double price = double.Parse(tokens[1]);
                    int quantity = int.Parse(tokens[2]);

                    totalPrice[product] = price;
                    totalQuantity[product] += quantity;
                }
                else
                {
                    double price = double.Parse(tokens[1]);
                    int quantity = int.Parse(tokens[2]);

                    totalQuantity.Add(product, quantity);
                    totalPrice.Add(product, price);
                }

                input = Console.ReadLine();
            }

            foreach (var (product, quantity) in totalQuantity)
            {
                double price = totalPrice[product];
                double results = quantity * price;
                Console.WriteLine($"{product} -> {results:f2}");
            }
        }
    }
}