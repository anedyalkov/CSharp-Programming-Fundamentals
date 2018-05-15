namespace _02.Array_Elements_Equal_to_Their_Index
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
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i)
                {
                    if (i == numbers.Length - 1)
                    {
                        Console.Write(numbers[i]);
                    }
                    else
                    {
                        Console.Write(numbers[i] + " ");
                    }
                    
                }
            }
            Console.WriteLine();
        }
    }
}
