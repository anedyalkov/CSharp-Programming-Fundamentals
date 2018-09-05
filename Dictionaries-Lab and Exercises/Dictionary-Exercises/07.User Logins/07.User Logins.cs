namespace _07.User_Logins
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var resultDict = new SortedDictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "login")
            {
                var elements = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var username = elements[0];
                var password = elements[1];

                resultDict[username] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            var count = 0;

            while (input != "end")
            {

                var elements = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var username = elements[0];
                var password = elements[1];

                if (!resultDict.ContainsKey(username) || !resultDict.ContainsValue(password))
                {
                    count++;
                    Console.WriteLine($"{username}: login failed");
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
