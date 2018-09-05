namespace _06.Exam_Shopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dict = new Dictionary<string, int>();

            while (input != "shopping time")
            {
                var inputElements = input.Split(": ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var firstElement = inputElements[0];
                var product = inputElements[1];
                var quantity = int.Parse(inputElements[2]);

                if (!dict.ContainsKey(product))
                {
                    dict[product] = 0;
                }
                dict[product] += quantity;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "exam time")
            {

                var inpuLineElements = input.Split(": ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var firstElement = inpuLineElements[0];
                var product = inpuLineElements[1];
                var quantity = int.Parse(inpuLineElements[2]);

                if (!dict.ContainsKey(product))
                {
                    Console.WriteLine("{0} doesn't exist", product);
                }
                else if (dict[product] == 0)
                {
                    Console.WriteLine("{0} out of stock", product);
                }
                else if (dict.ContainsKey(product))
                {
                    dict[product] -= quantity;
                    if (dict[product] < 0)
                    {
                        dict[product] = 0;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var productQuantityPair in dict)
            {
                var product = productQuantityPair.Key;
                var quantity = productQuantityPair.Value;

                if (quantity > 0)
                {
                    Console.WriteLine("{0} -> {1}", product, quantity);
                }
            }
        }
    }
}
