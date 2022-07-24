using System;
namespace PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();

            var input = Console.ReadLine();
            while (input != "Done")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "TakeOdd")
                {
                    password = TakeOdd(password);
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    password = Cut(password, tokens);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    var result = Substitute(password, tokens);
                    if (result != "Nothing to replace!")
                        password = Substitute(password, tokens);
                    
                    Console.WriteLine(result);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }

        static string TakeOdd(string password)
        {
            var result = "";

            for (int i = 0; i < password.Length; i++)
                if (i % 2 != 0) result += password[i];

            return result;
        }

        static string Cut(string password, string[] tokens)
        {
            int index = int.Parse(tokens[1]);
            int length = int.Parse(tokens[2]);
            var result = "";
            result = password.Remove(index, length);

            return result;
        }

        static string Substitute(string password, string[] tokens)
        {
            var error = "Nothing to replace!";

            string substring = tokens[1];
            string substitute = tokens[2];

            var result = password.Replace(substring, substitute);

            if (result != password)
                return result;
            else
                return error;
        }
    }
}