namespace _03.Phonebook
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine()
               .Split(' ')
               .ToArray();

            var names = Console.ReadLine()
               .Split(' ')
               .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "done")
            {

                for (int i = 0; i < names.Length; i++)
                {
                    if (input == names[i])
                    {
                        Console.WriteLine($"{input} -> {phoneNumbers[i]}");
                    }
                }
            }
        }
    }
}
