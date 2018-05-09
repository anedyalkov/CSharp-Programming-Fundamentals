namespace _01.Largest_Element_in_Array
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

            var maxValue = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
