using System;
using System.Text;

namespace TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            StringBuilder message = new StringBuilder(encryptedMessage);

            string input = Console.ReadLine();

            while (input!="Decode")
            {
                string[] tokens = input.Split('|');
                string command = tokens[0];


                switch (command)
                {
                    case "Move":
                        int count = int.Parse(tokens[1]);
                        for (int i = 0; i < count; i++)
                        {
                            message.Append(message[0]);
                            message.Remove(0, 1);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string value = tokens[2];

                        message.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string substring = tokens[1];
                        string replacement = tokens[2];

                        message.Replace(substring, replacement);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}