namespace _03.Letter_Repetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var symbols = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            var result = new List<string>();

            for (int i = 0; i < symbols.Length; i++)
            {
                if (!dict.ContainsKey(symbols[i]))
                {
                    dict[symbols[i]] = 0;

                }

                dict[symbols[i]]++;
            }

            foreach (var symbolOccurancePair in dict)
            {
                var symbol = symbolOccurancePair.Key;
                var occurance = symbolOccurancePair.Value;

                Console.WriteLine("{0} -> {1}", symbol, occurance);
            }
        }
    }
}
