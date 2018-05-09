namespace _04.CountOccurrencesOfLargerNumbersInArray
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToArray();

            var number = double.Parse(Console.ReadLine());

            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > number)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
