namespace _05.Integer_to_Base
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string intToBase = IntegerToBase(number, toBase);
            Console.WriteLine(intToBase);
        }

        public static string IntegerToBase(int number, int toBase)
        {
            var resultAsString = "";

            while (number > 0)
            {
                var firstDigit = number % toBase;
                number = number / toBase;
                resultAsString = firstDigit.ToString() + resultAsString;
            }

            return resultAsString;
        }
    }
}
