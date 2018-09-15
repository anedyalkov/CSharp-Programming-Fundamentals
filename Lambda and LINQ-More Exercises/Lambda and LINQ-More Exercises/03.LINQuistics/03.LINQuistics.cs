namespace _03.LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var collectionMethods = new Dictionary<string, HashSet<string>>();

            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                var inputParts = input.Split(new[] { ' ', ')', '(', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputParts.Length > 1 && inputParts[0].Length > 1)
                {
                    var collectionName = inputParts[0];
                    var methods = inputParts.Skip(1).ToList();

                    if (!collectionMethods.ContainsKey(collectionName))
                    {
                        collectionMethods[collectionName] = new HashSet<string>();
                    }

                    for (int i = 0; i < methods.Count; i++)
                    {
                        var currentMethod = methods[i];
                        collectionMethods[collectionName].Add(currentMethod);
                    }
                }
                else if (inputParts.Length == 1 && inputParts[0].Length > 1)
                {
                    var collection = inputParts[0];
                    if (!collectionMethods.ContainsKey(collection))
                    {
                        continue;
                    }

                    var orderedMethods = collectionMethods[collection]
                        .OrderByDescending(x => x.Length)
                        .ThenByDescending(x => x.Distinct().Count())
                        .ToList();

                    foreach (var value in orderedMethods)
                    {
                        Console.WriteLine("* {0}", value);
                    }
                }
                else if(int.TryParse(inputParts[0], out int number) && collectionMethods.Count > 0)
                {
                    int digit = int.Parse(inputParts[0]);
                    var collectionMethod = collectionMethods.Values
                        .OrderByDescending(x => x.Count)
                        .First()
                        .OrderBy(x => x.Length)
                        .Take(digit)
                        .ToList();

                    foreach (var value in collectionMethod)
                    {
                        Console.WriteLine("* {0}", value);
                    }
                }
            }

            var line = Console.ReadLine();
           
                var inputElements = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var method = inputElements[0];
                var selection = inputElements[1];

                var allCollections = collectionMethods
                    .Where(x => x.Value.Contains(method))
                    .OrderByDescending(x => x.Value.Count)
                    .ThenByDescending(x => x.Value.Min(y => y.Length))
                    .ToDictionary(x => x.Key, x => x.Value);

            if (selection == "collection")
            {
                foreach (var key in allCollections.Keys)
                {
                    Console.WriteLine(key);
                }
            }
            else
            {
                foreach (var kvp in allCollections)
                {
                    Console.WriteLine(kvp.Key);

                    foreach (var item in allCollections[kvp.Key].OrderByDescending(x => x.Count()))
                    {
                        Console.WriteLine("* {0}", item);
                    }
                }
            }
                    
        }
    }
}
