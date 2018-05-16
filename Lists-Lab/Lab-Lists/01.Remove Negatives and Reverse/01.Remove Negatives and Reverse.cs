namespace _01.Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var positiveNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveNumbers.Add(numbers[i]);
                }   
            }

            if (positiveNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            positiveNumbers.Reverse();

            Console.WriteLine(string.Join(" ", positiveNumbers));
        }
    }
}
