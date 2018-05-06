namespace _01.Special_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var sum = 0;
            var currentNum = 0;
            bool isTrue;

            for (int i = 1; i <= input; i++)
            {
                currentNum = i;
                while (currentNum != 0)
                {
                    var lastDigit = currentNum % 10;
                    sum += lastDigit;
                    currentNum /= 10; 
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isTrue = true;
                    Console.WriteLine($"{i} -> {isTrue}");
                }
                else
                {
                    isTrue = false;
                    Console.WriteLine($"{i} -> {isTrue}");
                }
                sum = 0;
            }
        }
    }
}
