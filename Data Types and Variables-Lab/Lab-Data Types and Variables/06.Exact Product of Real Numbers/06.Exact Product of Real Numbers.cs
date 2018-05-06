namespace _06.Exact_Product_of_Real_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            decimal product = 1;

            for (int i = 0; i < n; i++)
            {
                product *= decimal.Parse(Console.ReadLine());

            }

            Console.WriteLine(product);
        }
    }
}
