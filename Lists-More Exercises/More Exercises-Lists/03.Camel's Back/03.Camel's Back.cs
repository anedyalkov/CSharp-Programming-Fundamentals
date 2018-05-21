namespace _03.Camel_s_Back
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

            var camelBacksSize = int.Parse(Console.ReadLine());

            var rounds = 0;

            while (numbers.Count != camelBacksSize )
            {
                for (int i = 0; i < numbers.Count/2; i++)
                {
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(numbers.Count - 1);
                    i = -1;
                    break;
                }

                rounds++;
            }

            if (rounds == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ",numbers)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ",numbers)}");
            }
        }
    }
}
