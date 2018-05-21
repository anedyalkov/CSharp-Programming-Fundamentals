namespace _04.Ununion_Lists
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

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();


                for (int j = 0; j < input.Count; j++)
                {
                    if (!numbers.Contains(input[j]))
                    {
                        numbers.Add(input[j]);
                        input.Remove(input[j]);
                        j = -1;
                    } 
                }


                for (int j = 0; j < input.Count; j++)
                {
                    if (numbers.Contains(input[j]))
                    {
                        numbers.RemoveAll(n => n == input[j]);
                    }
                }
            }

            numbers.Sort();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
