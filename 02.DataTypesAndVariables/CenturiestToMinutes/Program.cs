using System;

namespace CenturiestToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            double years = centuries * 100;
            double days = Math.Floor(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            Console.WriteLine(minutes);
            
        }
    }
}
