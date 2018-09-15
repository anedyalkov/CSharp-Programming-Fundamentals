namespace _01.Lambada_Expressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, string>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "lambada")
                {
                    break;
                }

                var inputParts = input.Split(" =>.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (input != "dance")
                {

                    string selector = inputParts[0];
                    string selectorObject = inputParts[1];
                    string property = inputParts[2];

                    if (!dict.ContainsKey(selector))
                    {
                        dict[selector] = new Dictionary<string, string>();
                    }
                    dict[selector][selectorObject] = property;
                }

                if (input == "dance")
                {
                    dict = dict
                        .ToDictionary(x => x.Key, x => x.Value
                        .ToDictionary(y => y.Key, y => y.Key + "." + y.Value));

                }
            }
            foreach (var kvp in dict)
            {
                var selector = kvp.Key;
                var selectorObjectProperty = kvp.Value;

                Console.Write($"{selector} => ");

                foreach (var pair in selectorObjectProperty)
                {
                    var selectorObject = pair.Key;
                    var property = pair.Value;

                    Console.WriteLine($"{selectorObject}.{property}");
                }
            }
        }
    }
}
