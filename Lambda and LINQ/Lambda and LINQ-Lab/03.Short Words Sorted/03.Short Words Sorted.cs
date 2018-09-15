namespace _03.Short_Words_Sorted
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(" ,;:.!()\"'\\/[]|?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            var sortedText = text
                .Where(x => x.Length < 5)
                .Select(x => x.ToLower())
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", sortedText));
        }
    }
}
