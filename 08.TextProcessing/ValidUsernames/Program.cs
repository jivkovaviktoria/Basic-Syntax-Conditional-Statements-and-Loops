using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
                if(IsValid(username))
                    Console.WriteLine(username);
            }

        }
        static bool IsValid(string username)
        {
            bool isValid = true;

            if (username.Length < 3 || username.Length > 16)
                isValid = false;

            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetter(username[i]) && !char.IsDigit(username[i]) && !IsHyphenOrUnderscore(username[i]))
                    isValid = false;
            }

            return isValid;
        }
        static bool IsHyphenOrUnderscore(char symbol)
        {
            bool isTrue = false;

            if (symbol == '-' || symbol == '_')
                isTrue = true;

            return isTrue;
        }
    }
}
