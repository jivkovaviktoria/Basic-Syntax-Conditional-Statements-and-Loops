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

            bool isLetterOrDigit = true;
            foreach (char c in pass)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c))
                {
                    isLetterOrDigit = false;
                    isValid = false;
                }
            }
            if (isLetterOrDigit==false)
                Console.WriteLine("Password must consist only of letters and digits");

            int counter = 0;
            foreach (char c in pass)
            {
                if (char.IsDigit(c))
                    counter++;
            }
            if (counter < 2)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid == true)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
