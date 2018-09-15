namespace _03.Record_Unique_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                set.Add(input);
            }

            Console.WriteLine(string.Join(Environment.NewLine,set));
        }
    }
}
