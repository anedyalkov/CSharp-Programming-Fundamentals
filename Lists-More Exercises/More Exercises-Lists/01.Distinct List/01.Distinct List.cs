namespace _01.Distinct_List
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] == currentNumber)
                    {
                        numbers.RemoveAt(j);
                        i = 0;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
