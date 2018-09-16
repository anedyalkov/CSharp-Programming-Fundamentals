namespace _02.Match_Phone_Number
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            string pattern = @"(^| )\+359( |-)2\2\d{3}\2\d{4}\b";

            var regex = new Regex(pattern);

            var matchedPhones = regex.Matches(input);

            var phones = new List<string>();

            foreach (Match phone in matchedPhones)
            {
                phones.Add(phone.Value);
            }

            Console.WriteLine(string.Join(",",phones));
        }
    }
}
