namespace _03.Printing_Triangle
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            PrintTriangle(count);
        }

        public static void PrintTriangle(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                PrintLine(i);
            }

            for (int i = count - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        public static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
