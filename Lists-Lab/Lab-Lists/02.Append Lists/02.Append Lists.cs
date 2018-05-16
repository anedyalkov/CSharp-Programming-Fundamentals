namespace _02.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { '|' })
                .ToList();

            input.Reverse();

            var result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                var currentString = input[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var element in currentString)
                {
                    result.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
