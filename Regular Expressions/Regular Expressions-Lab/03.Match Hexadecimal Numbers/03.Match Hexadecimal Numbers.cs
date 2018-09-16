namespace _03.Match_Hexadecimal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            string pattern = @"\b(0x)?[0-9A-F]+\b";

            var regex = new Regex(pattern);

            var matchedHexadecimalNums = regex.Matches(input);

            var nums = new List<string>();

            foreach (Match number in matchedHexadecimalNums)
            {
                nums.Add(number.Value);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
