using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop") break;

                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                    resources.Add(resource, quantity);
                else
                    resources[resource] += quantity;
            }

            foreach (var item in resources)
                Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
