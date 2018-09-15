namespace _04.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            var k = nums.Count / 4;

            var leftPart = nums
                .Take(k)
                .Reverse()
                .ToList();

            var rightPart = nums
                .Skip(3 * k)
                .Take(k)
                .Reverse()
                .ToList();

            var row1 = leftPart.Concat(rightPart).ToList();
            var row2 = nums.Skip(k).Take(2 * k).ToList();

            var summedNums = new List<int>();

            for (int i = 0; i < row1.Count; i++)
            {
                var sum = row1[i] + row2[i];
                summedNums.Add(sum);
            }

            Console.WriteLine(string.Join(" ",summedNums));
        }
    }
}
