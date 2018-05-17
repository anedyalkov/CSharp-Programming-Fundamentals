namespace _03.Equal_Sum_After_Extraction
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstIntegerList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var secondIntegerList = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            for (int i = 0; i < firstIntegerList.Count; i++)
            {
                if (secondIntegerList.Contains(firstIntegerList[i]))
                {
                    secondIntegerList.Remove(firstIntegerList[i]);
                }
            }

            var firstIntegerListResult = firstIntegerList.Sum();
            var secondIntegerListResult = secondIntegerList.Sum();

            if (firstIntegerListResult == secondIntegerListResult)
            {
                Console.WriteLine($"Yes. Sum: {firstIntegerListResult}");
            }
            else
            {
                var difference = firstIntegerListResult - secondIntegerListResult;
                Console.WriteLine($"No. Diff: {Math.Abs(difference)}");
            }
        }
    }
}
