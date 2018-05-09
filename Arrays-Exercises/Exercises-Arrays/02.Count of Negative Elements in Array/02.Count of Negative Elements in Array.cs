namespace _02.Count_of_Negative_Elements_in_Array
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            var array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
