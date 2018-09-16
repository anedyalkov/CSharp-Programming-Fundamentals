namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var regex = new Regex(pattern);

            var names = regex.Matches(input);

            foreach (Match name in names)
            {
                Console.Write($"{name.Value} ");
            }

            Console.WriteLine();
        }
    }
}
