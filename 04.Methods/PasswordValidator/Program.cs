using System;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            ValidPassword(pass);
        }

        static void ValidPassword(string pass)
        {
            bool isValid = true;
            if (pass.Length < 6 || pass.Length > 10)
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool isLetterOrDigit = ContainsOnlyValidCharacters(pass);
            if (isLetterOrDigit == false)
            {
                isValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool containsEnoughDigits = ContainsAtLeastTwoDigits(pass);
            if (containsEnoughDigits == false)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ContainsAtLeastTwoDigits(string pass)
        {
            int counter = 0;
            foreach (char c in pass)
            {
                if (char.IsDigit(c))
                    counter++;
            }

            return counter >= 2;
        }

        private static bool ContainsOnlyValidCharacters(string pass)
        {
            foreach (char c in pass)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c)) return false;
            }
            
            return true;
        }
    }
}
