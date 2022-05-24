using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string firstName = Console.ReadLine();
            string secondtName = Console.ReadLine();

            string delimiter = Console.ReadLine();

            Console.WriteLine($"{firstName} {delimiter} {secondtName}");
        }
    }
}
