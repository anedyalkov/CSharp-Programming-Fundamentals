namespace _03.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            var sum = 0m;
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    sum = numbers[i] + numbers[i + 1];
                    numbers[i] = sum;
                    numbers.RemoveAt(i+1);
                    sum = 0;
                    i = -1;
                } 
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
