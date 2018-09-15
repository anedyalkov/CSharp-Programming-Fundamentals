namespace _02.Dict_Ref_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dict = new Dictionary<string, List<int>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var inputElements = input.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = inputElements[0];

                var values = new List<int>();


                if (int.TryParse(inputElements[1], out int number))
                {
                    values = inputElements.Skip(1).Select(int.Parse).ToList();
                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = new List<int>();
                    }

                    for (int i = 0; i < values.Count; i++)
                    {
                        dict[name].Add(values[i]);
                    }
                }
                else
                {
                    var secondName = inputElements[1];
                    if (dict.ContainsKey(secondName))
                    {
                        //dict[name] = new List<int>(dict[secondName]);
                        dict[name] = dict[secondName].ToList();
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            foreach (var kvp in dict)
            {
                var key = kvp.Key;
                var values = kvp.Value;

                Console.WriteLine($"{key} === {string.Join(", ",values)}");
            }
        }
    }
}
