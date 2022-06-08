using System;

namespace Orders
{
    internal class Program
    {
        static void Order(string order, int quantity)
        {
            double price = 0;
            double total = 0;
            switch (order)
            {
                case "coffee": price = 1.50; break;
                case "water": price = 1.00; break;
                case "coke": price = 1.40; break;
                case "snacks": price = 2.00; break;
                default:
                    break;
            }
            Console.WriteLine($"{price*quantity:f2}");
        }
        static void Main(string[] args)
        {
           string order = Console.ReadLine();
           int quantity = int.Parse(Console.ReadLine());
            Order(order, quantity);
        }
    }
}
