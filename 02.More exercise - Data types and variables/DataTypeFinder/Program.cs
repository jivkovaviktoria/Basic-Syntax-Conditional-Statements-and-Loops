using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "END")
            {
                if (int.TryParse(text, out _)) { Console.WriteLine($"{text} is integer type"); }
                else if (double.TryParse(text, out _)) { Console.WriteLine($"{text} is floating point type"); }
                else if (char.TryParse(text, out _)) { Console.WriteLine($"{text} is character type"); }
                else if (bool.TryParse(text, out _)) { Console.WriteLine($"{text} is boolean type"); }
                else { Console.WriteLine($"{text} is string type"); }

                text = Console.ReadLine();
            }
        }
    }
}
