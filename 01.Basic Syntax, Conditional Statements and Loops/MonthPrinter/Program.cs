using System;

namespace MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 12)
            {
                Console.WriteLine("Error!");
                return;
            }

            string[] month = { "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December" };

            Console.WriteLine(month[num - 1]);
        }
    }
}
