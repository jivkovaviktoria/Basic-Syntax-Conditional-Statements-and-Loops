using System;
using System.Text;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < count; i++)
            {
                string info = Console.ReadLine();

                var nameStartIndex = info.IndexOf("@");
                var nameEndIndex = info.IndexOf("|");
                var ageStartIndex = info.IndexOf("#");
                var ageEndIndex = info.IndexOf("*");

                StringBuilder name = new StringBuilder();

                for (int j = nameStartIndex + 1; j < nameEndIndex; j++)
                    name.Append(info[j]);

                StringBuilder age = new StringBuilder();

                for (int k = ageStartIndex + 1; k < ageEndIndex; k++)
                    age.Append(info[k]);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
