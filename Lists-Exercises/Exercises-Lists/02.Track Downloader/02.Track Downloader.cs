namespace _02.Track_Downloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var blacklistedWords = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();

            var fileNames = new List<string>();
            bool inputContainsBlackListedWord = false;

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                for (int i = 0; i < blacklistedWords.Count; i++)
                {
                    if (input.Contains(blacklistedWords[i]))
                    {
                        inputContainsBlackListedWord = true;
                        break;
                    }

                }
                if (!inputContainsBlackListedWord)
                {
                    fileNames.Add(input);
                }
                inputContainsBlackListedWord = false;
            }

            fileNames.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, fileNames));
        }
    }
}
