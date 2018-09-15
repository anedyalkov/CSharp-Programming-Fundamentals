namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            
            var input = Console.ReadLine().Split(",?.! ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            var palindromes = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentWord = input[i];
                var reversedWord = new string(currentWord.Reverse().ToArray());
                if (reversedWord == currentWord)
                {
                    palindromes.Add(currentWord);
                }
            }
                var orderedPalindromes = palindromes.Distinct().OrderBy(w => w).ToList();

                Console.WriteLine(string.Join(", ",orderedPalindromes));
        }
    }
}
