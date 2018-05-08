namespace _14.Tricky_Strings
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();

            var counter = int.Parse(Console.ReadLine());

            var words = new List<string>();

            for (int i = 0; i < counter; i++)
            {
                var word = Console.ReadLine();
                words.Add(word);
            }

            Console.WriteLine(string.Join(delimiter,words));
        }
    }
}
