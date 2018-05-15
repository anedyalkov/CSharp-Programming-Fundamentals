namespace _05.Char_Rotation
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            char[] symbols = Console.ReadLine()
                .ToCharArray();

            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    symbols[i] -= (char)numbers[i];
                }
                else
                {
                    symbols[i] += (char)numbers[i];
                }

                Console.Write(symbols[i]);
            }
            Console.WriteLine();
        }
    }
}
