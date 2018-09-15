namespace _01.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var regionShells = new Dictionary<string, HashSet<int>>();

            string input;

            while ((input = Console.ReadLine()) != "Aggregate")
            {
                var inputElements = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var town = inputElements[0];
                var shellSize = int.Parse(inputElements[1]);

                if (!regionShells.ContainsKey(town))
                {
                    regionShells[town] = new HashSet<int>();
                }

                regionShells[town].Add(shellSize);
            }

            foreach (var kvp in regionShells)
            {
                var region = kvp.Key;
                var shellSizes = kvp.Value;

                var giantShell = shellSizes.Sum() - (shellSizes.Sum() / shellSizes.Count());

                Console.WriteLine($"{region} -> {string.Join(", ",shellSizes)} ({giantShell})");
            }
        }
    }
}
