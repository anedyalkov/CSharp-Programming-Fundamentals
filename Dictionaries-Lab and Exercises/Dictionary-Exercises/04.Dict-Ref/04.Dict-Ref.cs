namespace _04.Dict_Ref
{
    using System;
    using System.Collections.Generic;


    public class Program
    {
        public static void Main()
        {
            var resultDict = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split();

                var firstElement = tokens[0];
                var lastElement = tokens[1];

                var number = 0;

                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var referencedValue = resultDict[lastElement];
                        resultDict[firstElement] = referencedValue;
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var itemPricePair in resultDict)
            {
                var item = itemPricePair.Key;
                var price = itemPricePair.Value;

                Console.WriteLine($"{item} === {price}");
            }
        }
    }
}
