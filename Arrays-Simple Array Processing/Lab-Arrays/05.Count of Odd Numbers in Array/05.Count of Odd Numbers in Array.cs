namespace _05.Count_of_Odd_Numbers_in_Array
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

            var count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
