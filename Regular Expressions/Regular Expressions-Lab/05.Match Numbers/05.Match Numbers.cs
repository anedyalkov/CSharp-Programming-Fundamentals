namespace _05.Match_Numbers
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            string pattern = @"(^|(?<=\s))(-?)\d+(\.?\d+)?($|(?=\s))";

            var regex = new Regex(pattern);

            var matchedNums = regex.Matches(input);

            foreach (Match number in matchedNums)
            {
                Console.Write($"{number.Value + " "}");
            }
            Console.WriteLine();
        }
    }
}
