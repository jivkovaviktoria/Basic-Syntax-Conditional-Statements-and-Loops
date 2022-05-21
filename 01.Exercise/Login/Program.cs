using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int usernameLenght = username.Length - 1;
            string password = "";

            for (int i = usernameLenght; i >= 0; i--)
            {
                password += username[i];
            }

            int countOfWrongPasswords = 0;
            string inputPassword = Console.ReadLine();

            while (inputPassword != password)
            {
                countOfWrongPasswords++;
                if (countOfWrongPasswords > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }

            if (inputPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
