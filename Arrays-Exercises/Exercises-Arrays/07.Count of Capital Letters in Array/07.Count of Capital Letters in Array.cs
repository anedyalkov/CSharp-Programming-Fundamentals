namespace _07.Count_of_Capital_Letters_in_Array
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .ToArray();

            var count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var firstLetter = words[i][0];
                if (words[i].Length == 1 && char.IsUpper(firstLetter))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
