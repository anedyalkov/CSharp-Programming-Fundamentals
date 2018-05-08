namespace _01.Sum_Array_Elements
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                sum += array[i];
            }

            Console.WriteLine(sum);
        }
    }
}
