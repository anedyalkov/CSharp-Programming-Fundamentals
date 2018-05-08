namespace _06.Math_Power
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            var raisedValue = RaiseToPower(number, power);
            Console.WriteLine(raisedValue);
        }

        private static double RaiseToPower(double number, int power)
        {
            var result = 0.0;

            result = Math.Pow(number, power);

            return result;
        }
    }
}
