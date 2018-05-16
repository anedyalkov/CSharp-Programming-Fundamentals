namespace _07.Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            var orderedNumbers = new Dictionary<int, int>();

            numbers.Sort();
            numbers.Add(int.MaxValue);

            var count = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    continue;
                }

                orderedNumbers.Add(numbers[i], count);
                count = 1;
            }

             orderedNumbers.ToList()
                .ForEach(kvp => Console.WriteLine($"{kvp.Key} -> {kvp.Value}"));
        }
    }
}
