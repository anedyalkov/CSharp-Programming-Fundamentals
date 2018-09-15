namespace _01.Serialize_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dict = new Dictionary<string, List<string>>();

            var firstSymbol = input[0];

           
            for (int i = 0; i < input.Length; i++)
            {
                var currentSymbol = input[i].ToString();

                if (!dict.ContainsKey(currentSymbol))
                {
                    dict[currentSymbol] = new List<string>();
                }

                dict[currentSymbol].Add(i.ToString());
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}:{string.Join("/",kvp.Value)}");
            }
        }
    }
}
