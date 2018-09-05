namespace _05.Mixed_Phones
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var resultDict = new SortedDictionary<string, decimal>();

            var input = Console.ReadLine();

            while (input != "Over")
            {
                var elements = input.Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var firstElement = elements[0];
                var secondElement = elements[1];

                var number = 0m;

                if (decimal.TryParse(secondElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    var temp = secondElement;
                    secondElement = firstElement;
                    firstElement = temp;

                    if (decimal.TryParse(secondElement, out number))
                    {
                        resultDict[firstElement] = number;
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var nameNumberPair in resultDict)
            {
                var name = nameNumberPair.Key;
                var number = nameNumberPair.Value;

                Console.WriteLine($"{name} -> {number}");
            }
        }
    }
}
