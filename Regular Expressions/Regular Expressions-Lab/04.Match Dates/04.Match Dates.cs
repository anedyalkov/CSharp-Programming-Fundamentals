namespace _04.Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            string pattern = @"\b(\d{2})(\/|.|-)([A-Z][a-z]{2})\2(\d{4})\b";

            var regex = new Regex(pattern);

            var matchedDates = regex.Matches(input);

            foreach (Match date in matchedDates)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }          
        }
    }
}
