namespace _02.Default_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dict = new Dictionary<string, string>();

            string input;
            while ((input = Console.ReadLine())!="end")
            {
                var inputElements = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var key = inputElements[0];
                var value = inputElements[1];

                if (!dict.ContainsKey(key))
                {
                    dict[key] = value;
                }

                dict[key] = value;
            }
            var defaultValue = Console.ReadLine();

           var unchangedValues = dict
               .Where(x => x.Value != "null")
               .OrderByDescending(x => x.Value.Length)
               .ToDictionary(x => x.Key, x => x.Value);


            var changedValues = dict
               .Where(x => x.Value == "null")
               .ToDictionary(x => x.Key, x => defaultValue);

            PrintUnchangedValues(unchangedValues);

            PrintChangedValues(changedValues);


        }

        private static void PrintChangedValues(Dictionary<string, string> changedValues)
        {
            foreach (var pair in changedValues)
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");

            }
        }

        private static void PrintUnchangedValues(Dictionary<string, string> unchangedValues)
        {
            foreach (var pair in unchangedValues)
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");
            }
        }
    }
}
