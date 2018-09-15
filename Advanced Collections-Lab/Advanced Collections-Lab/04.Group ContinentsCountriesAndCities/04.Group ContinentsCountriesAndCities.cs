namespace _04.Group_ContinentsCountriesAndCities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var continents = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent][country] = new SortedSet<string>();
                }

                continents[continent][country].Add(city);
            }

            foreach (var kvp in continents)
            {
                var continent = kvp.Key;
                var countryCities = kvp.Value;

                Console.WriteLine($"{continent}:");

                foreach (var countryTowns in countryCities)
                {
                    var country = countryTowns.Key;
                    var towns = countryTowns.Value;

                    Console.WriteLine($"{country} -> {string.Join(", ", towns)}");
                }
            }
        }
    }
}
