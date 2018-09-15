namespace _02.Count_Substring_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var index = input.IndexOf(pattern);

            var count = 0;

            while (true)
            {
                if (index < 0)
                {
                    break;
                }             
                count++;

                index = input.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
               
        }
    }
}
