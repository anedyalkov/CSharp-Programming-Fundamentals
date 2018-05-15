namespace _01.Last_3_Consecutive_Equal_Strings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var reversedWords = words.Reverse().ToArray();
            var count = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (reversedWords[i] == reversedWords[i + 1])
                {
                    count++;
                    if (count == 2)
                    {
                        Console.WriteLine(reversedWords[i] + " " + reversedWords[i] + " " + reversedWords[i]);
                        return;
                    }
                }
                else
                {
                    count = 0;
                }
            }
        }
    }
}
