namespace _06.Square_Numbers
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

            var squareNumbers = new List<int>();

            foreach (var number in numbers)
            {
                var result = Math.Sqrt(number);

                if (result % 1 == 0)
                {
                    squareNumbers.Add(number);
                }
            }

            var orderedNumbers = squareNumbers.OrderByDescending(n => n).ToList();

            Console.WriteLine(string.Join(" ", orderedNumbers));
        }
    }
}
