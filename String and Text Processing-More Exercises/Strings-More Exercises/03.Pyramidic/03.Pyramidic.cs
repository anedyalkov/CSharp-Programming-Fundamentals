namespace _03.Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<string>>();
            var strings = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                strings.Add(input);
            }
            var firstString = strings[0];


            for (int i = 0; i < strings.Count; i++)
            {
                var currentLine = strings[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    var currentChar = currentLine[j];

                    var count = 1;

                    for (int k = i; k < strings.Count; k++)
                    {
                        var currentLayer = new string(currentChar, count);

                        if (strings[k].Contains(currentLayer))
                        {
                            if (!dict.ContainsKey(currentChar.ToString()))
                            {
                                dict[currentChar.ToString()] = new List<string>();
                            }

                            dict[currentChar.ToString()].Add(currentLayer);
                            count += 2;
                        }
                    }
                }
            }


            var newDict = dict.ToDictionary(c => c.Key, c => c.Value.Distinct().ToList());

            var orderedDictionary = newDict
               .OrderByDescending(x => x.Value.Count)
               .ToDictionary(x => x.Key, x => x.Value)
               .First();

            foreach (var value in orderedDictionary.Value)
            {
                Console.WriteLine(value);
            }

        }
    }
}
