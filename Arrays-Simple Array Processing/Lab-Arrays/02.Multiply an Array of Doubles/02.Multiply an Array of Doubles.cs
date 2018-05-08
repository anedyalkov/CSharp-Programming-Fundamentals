namespace _02.Multiply_an_Array_of_Doubles
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(    )
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var multyplier = double.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * multyplier;           
            }

            Console.WriteLine(string.Join(" ",array));
        }
    }
}
