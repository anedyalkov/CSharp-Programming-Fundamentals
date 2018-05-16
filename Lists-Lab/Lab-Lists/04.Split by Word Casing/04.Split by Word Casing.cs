namespace _04.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var separators = " ,;:.!()\"'\\/[]".ToCharArray();

            var strings = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (var element in strings)
            {
                if (element.All(e => char.IsUpper(e)))
                {
                    upperCaseWords.Add(element);
                }
                else if (element.All(e => char.IsLower(e)))
                {
                    lowerCaseWords.Add(element);
                }
                else
                {
                    mixedCaseWords.Add(element);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ",mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ",upperCaseWords)}");
        }
    }
}
