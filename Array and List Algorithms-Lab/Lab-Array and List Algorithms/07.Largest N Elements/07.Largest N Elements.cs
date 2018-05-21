namespace _07.Largest_N_Elements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
           var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var j = i + 1;

                while (j > 0)
                {
                    if (numbers[j] > numbers[j - 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;

                    }

                    j--;
                }

            }
 
            var result = numbers.Take(n);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
