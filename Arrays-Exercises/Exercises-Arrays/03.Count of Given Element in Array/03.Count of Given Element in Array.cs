namespace _03.Count_of_Given_Element_in_Array
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

            var element = int.Parse(Console.ReadLine());

            var count = 0;

            foreach (var number in array)
            {
                if (number == element)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
