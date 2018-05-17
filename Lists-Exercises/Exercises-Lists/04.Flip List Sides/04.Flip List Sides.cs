namespace _04.Flip_List_Sides
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

            for (int i = 1; i < numbers.Count/2; i++)
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
