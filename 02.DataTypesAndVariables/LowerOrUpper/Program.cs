using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());

            if (Char.IsLower(firstChar))
            {
                Console.WriteLine("lower-case");
            }
            else if (Char.IsUpper(firstChar))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
