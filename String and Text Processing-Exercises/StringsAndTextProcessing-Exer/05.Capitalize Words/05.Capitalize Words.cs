namespace _05.Capitalize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
           
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var tokens = input.ToLower().Split(new char[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var capitalizedWords = new List<string>();
                for (int i = 0; i < tokens.Length; i++)
                {
                    var currentWord = tokens[i];

                    var firstLetter = currentWord[0].ToString().ToUpper();
                    var otherLetters = new string(currentWord.Skip(1).ToArray());

                    var capitalizedWord = firstLetter + otherLetters;

                    capitalizedWords.Add(capitalizedWord);
                }

                Console.WriteLine(string.Join(", ", capitalizedWords));
            }
        }
    }
}
