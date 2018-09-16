namespace _06.Replace_a_Tag
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var pattern = @"(\s*)<a href=""(.+)?"">(\w*)<\/a>(\s*)";
                var regex = new Regex(pattern);
                bool containsValidData = regex.IsMatch(input);

                input = regex.Replace(input,"$1[URL href=\"$2\"]$3[/URL]$4");

                Console.WriteLine(input);
            }
        }
    }
}
