using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double tax = 0;
            double taxesTotal = 0;
            double totalWithoutTaxes = 0;
            double total = 0;
            double price = 0;

            while (input != "special" && input != "regular")
            {
                
                price = double.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                tax = price * 0.2;
                totalWithoutTaxes += price;
                taxesTotal += tax;
                total += price + tax;

                input = Console.ReadLine();
            }

            if(total==0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            if(input == "special")
            {
                total -= total * 0.1;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxesTotal:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {total:f2}$");

        }
    }
}
