namespace _05.Tear_List_in_Half
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

            var firstList = new List<int>();
            var secondList = new List<int>();
            var result = new List<int>();

            for (int i = numbers.Count / 2; i < numbers.Count; i++)
            {
                firstList.Add(numbers[i]);
            }

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                secondList.Add(numbers[i]);
            }
            for (int i = 0; i < firstList.Count; i++)
            {
                result.Add(firstList[i] / 10);
                result.Add(secondList[i]);
                result.Add(firstList[i] % 10);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
