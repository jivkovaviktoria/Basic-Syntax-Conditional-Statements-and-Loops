using System;

namespace Notifications
{
    class Program
    {

        static void ReadAndProcessMessage(string command)
        {
            if (command == "success")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();
                ShowSuccessMessage(operation, message);
            }
            else if (command == "error")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();
                int errorCode = int.Parse(Console.ReadLine());
                ShowErrorMessage(operation, message, errorCode);
            }
            else if (command == "warning")
            {
                string message = Console.ReadLine();
                ShowWarningMessage(message);
            }
        }
        static void ShowErrorMessage(string operation, string message, int errorCode)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("========================================");
            Console.WriteLine($"Reason: {message}.");
            Console.WriteLine($"Error code: {errorCode}");
        }
        static void ShowSuccessMessage(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("========================================");
            Console.WriteLine(message);
        }
        static void ShowWarningMessage(string message)
        {
            Console.WriteLine($"Warning: {message}");
            Console.WriteLine("========================================");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                
                ReadAndProcessMessage(command);
            }
        }
    }
}
