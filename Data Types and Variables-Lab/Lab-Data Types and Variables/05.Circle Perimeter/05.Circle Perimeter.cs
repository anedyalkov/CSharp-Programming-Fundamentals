namespace _05.Circle_Perimeter
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            var perimeter = r * Math.PI * 2;

            Console.WriteLine("{0:F12}", perimeter);
        }
    }
}
