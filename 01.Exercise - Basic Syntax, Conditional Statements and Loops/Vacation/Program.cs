using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            double people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double price = 0;

            if (day == "friday")
            {
                if (type == "students") price = 8.45;
                else if (type == "business") price = 10.90;
                else if (type == "regular") price = 15;
            }

            if (day == "saturday")
            {
                if (type == "students") price = 9.80;
                else if (type == "business") price = 15.60;
                else if (type == "regular") price = 20;
            }

            if (day == "sunday")
            {
                if (type == "students") price = 10.46;
                else if (type == "business") price = 16;
                else if (type == "regular") price = 22.50;
            }

            double total = people * price;
            if (type == "students" && people >= 30) total = total - (total * 0.15);
            else if (type == "business" && people >= 100) total = price * (people - 10);
            else if (type == "regular" && people >= 10 && people <= 20) total = total - (total * 0.05);

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
