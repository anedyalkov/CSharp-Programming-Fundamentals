namespace _02.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');

            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }

            List<string> oddNumberWords = new List<string>();


            foreach (var kvp in result)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddNumberWords.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddNumberWords));
        }
    }
}
