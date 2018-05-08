using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            var nthDigit = FindNthDigit(number, index);
            Console.WriteLine(nthDigit);
        }

        public static int FindNthDigit(long number, int index)
        {
            int digit = 0;
            int count = 0;
            while (number > 0)
            {
                count++;

                if (count == index)
                {
                    digit = (int)number % 10;
                }
                else
                {
                    number = number / 10;

                }
            }
            return digit;
        }
    }
}
