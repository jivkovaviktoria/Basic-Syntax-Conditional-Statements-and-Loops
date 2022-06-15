using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < count; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            int counter = 1;
            foreach(var product in products)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }
        }
    }
}
