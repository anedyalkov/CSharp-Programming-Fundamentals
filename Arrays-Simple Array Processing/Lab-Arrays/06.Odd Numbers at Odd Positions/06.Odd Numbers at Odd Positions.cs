namespace _06.Odd_Numbers_at_Odd_Positions
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (Math.Abs(array[i]) % 2 != 0)
                    {
                        Console.WriteLine($"Index {i} -> {array[i]}");
                    }
                }
            }
        }
    }
}
