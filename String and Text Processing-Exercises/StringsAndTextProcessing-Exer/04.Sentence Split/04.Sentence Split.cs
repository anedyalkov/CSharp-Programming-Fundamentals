namespace _04.Sentence_Split
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var delimiters = Console.ReadLine();

            var newText = text.Split(new string[] { delimiters }, StringSplitOptions.None)
                .ToList();

            Console.WriteLine("[{0}]", string.Join(", ", newText));
        }
    }
}
