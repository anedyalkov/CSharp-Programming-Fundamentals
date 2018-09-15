namespace _01.Reverse_string
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var reversed = input.Reverse().ToArray();

            Console.WriteLine(reversed);
        }
    }
}
