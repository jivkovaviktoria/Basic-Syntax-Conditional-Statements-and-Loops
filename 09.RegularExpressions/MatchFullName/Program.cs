using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string names = Console.ReadLine();
            MatchCollection mathedNames = Regex.Matches(names, regex);

            foreach (Match match in mathedNames)
                Console.Write(match.Value + " ");

            Console.WriteLine();
        }
    }
}
