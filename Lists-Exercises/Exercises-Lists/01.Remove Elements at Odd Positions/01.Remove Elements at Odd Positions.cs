namespace _01.Remove_Elements_at_Odd_Positions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var strings = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var stringsAtOddPositions = new List<string>();

            for (int i = 0; i < strings.Count; i++)
            {
                if (i % 2 != 0)
                {
                    stringsAtOddPositions.Add(strings[i]);
                }
            }

            Console.WriteLine(string.Join(string.Empty,stringsAtOddPositions));
        }
    }
}
