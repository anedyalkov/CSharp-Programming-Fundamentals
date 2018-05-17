namespace _06.Stuck_Zipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
              .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            var secondList = Console.ReadLine()
              .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            var finalList = new List<int>();

            int firstListSmallestNumberLength = GetFirstListSmallestNumberLength(firstList);
            int secondListSmallestNumberLength = GetSecondListSmallestNumberLength(secondList);

            var minLength = Math.Min(firstListSmallestNumberLength, secondListSmallestNumberLength);

            RemoveNumbersInFirstList(firstList, minLength);
            RemoveNumbersInSecondList(secondList, minLength);

            if (firstList.Count == 0)
            {
                Console.WriteLine(string.Join(" ", secondList));
                return;
            }
            if (secondList.Count == 0)
            {
                Console.WriteLine(string.Join(" ", firstList));
                return;
            }

            InsertFirstListNumbersInSecondList(firstList, secondList);

            Console.WriteLine(string.Join(" ", secondList));

        }

        private static void InsertFirstListNumbersInSecondList(List<int> firstList, List<int> secondList)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                var index = i + 1 + i;
                if (index > secondList.Count)
                {
                    secondList.Add(firstList[i]);
                    continue;
                }
                secondList.Insert(index, firstList[i]);
            }
        }

        private static void RemoveNumbersInSecondList(List<int> secondList, int minLength)
        {
            for (int i = 0; i < secondList.Count; i++)
            {
                var currentNumber = Math.Abs(secondList[i]);
                var result = currentNumber.ToString();
                if (result.Length > minLength)
                {
                    secondList.RemoveAt(i);
                    i = -1;
                }
            }
        }

        private static void RemoveNumbersInFirstList(List<int> firstList, int minLength)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                var currentNumber = Math.Abs(firstList[i]);
                var currentNumberAsString = currentNumber.ToString();
                if (currentNumberAsString.Length > minLength)
                {
                    firstList.RemoveAt(i);
                    i = -1;
                }
            }
        }

        private static int GetSecondListSmallestNumberLength(List<int> secondList)
        {
            var secondListSmallestNumberLength = int.MaxValue;
            for (int i = 0; i < secondList.Count; i++)
            {
                var currentNumber = Math.Abs(secondList[i]);
                var currentNumberAsString = currentNumber.ToString();
                if (currentNumberAsString.Length < secondListSmallestNumberLength)
                {
                    secondListSmallestNumberLength = currentNumberAsString.Length;
                }
            }

            return secondListSmallestNumberLength;
        }

        private static int GetFirstListSmallestNumberLength(List<int> firstList)
        {
            var firstListSmallestNumberLength = int.MaxValue;
            for (int i = 0; i < firstList.Count; i++)
            {
                var currentNumber = Math.Abs(firstList[i]);
                var currentNumberAsString = currentNumber.ToString();
                if (currentNumberAsString.Length < firstListSmallestNumberLength)
                {
                    firstListSmallestNumberLength = currentNumberAsString.Length;
                }
            }

            return firstListSmallestNumberLength;
        }
    }
}
