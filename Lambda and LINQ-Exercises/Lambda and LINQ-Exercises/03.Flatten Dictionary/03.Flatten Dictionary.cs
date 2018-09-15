namespace _03.Flatten_Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, string>>();

            string input;
            while ((input = Console.ReadLine())!= "end")
            {
                var inputParts = input.Split(new[] { ' ', }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                

                if (inputParts[0] == "flatten")
                {
                    var key = inputParts[1];

                    dict[key] = dict[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flatten");
                    
                }
                else
                {
                    var key = inputParts[0];
                    var innerKey = inputParts[1];
                    var innerValue = inputParts[2];

                    if (!dict.ContainsKey(key))
                    {
                        dict[key] = new Dictionary<string, string>();
                    }

                    if (!dict[key].ContainsKey(innerKey))
                    {
                        dict[key][innerKey] = innerValue;
                    }

                    dict[key][innerKey] = innerValue;
                }
            }

            var orderedDict = dict
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedDict)
            {
                var key = kvp.Key;
                var innerDictionary = kvp.Value;

                Console.WriteLine(key);

                var orderedInnerDictionary = kvp.Value
                    .Where(x => x.Value!="flatten")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenDictionary = innerDictionary
                    .Where(x => x.Value == "flatten")
                    .ToDictionary(x => x.Key, x => x.Value);

                var count = 0;
                foreach (var pair in orderedInnerDictionary)
                {
                    count++;
                    Console.WriteLine($"{count}. {pair.Key} - {pair.Value}");
                }

                foreach (var pair in flattenDictionary)
                {
                    count++;
                    Console.WriteLine($"{count}. {pair.Key}");
                }
            }
        }
    }
}
