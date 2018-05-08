namespace _06.Notifications
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();
                if (input == "success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }

                else if (input == "error")
                {
                    var operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    var reason = String.Empty;
                    if (code >= 0)
                    {
                        reason = "Invalid Client Data";
                        ShowError(operation, code);
                        Console.WriteLine($"Reason: {reason}.");
                    }
                    else
                    {
                        reason = "Internal System Failure";
                        ShowError(operation, code);
                        Console.WriteLine($"Reason: {reason}.");
                    }
                }
            }


        }

        public static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed { operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");

        }

        public static void ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
        }
    }
}

