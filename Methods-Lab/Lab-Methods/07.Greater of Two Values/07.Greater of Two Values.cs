namespace _07.Greater_of_Two_Values
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                var firstNumber = int.Parse(Console.ReadLine());
                var secondNumber = int.Parse(Console.ReadLine());

                var maxInteger = GetMax(firstNumber, secondNumber);

                Console.WriteLine(maxInteger);

            }

            else if (type == "char")
            {
                var firstSymbol = char.Parse(Console.ReadLine());
                var secondSymbol = char.Parse(Console.ReadLine());

                var maxSymbol = GetMax(firstSymbol, secondSymbol);

                Console.WriteLine(maxSymbol);
            }


            else if (type == "string")
            {
                var firstWord = Console.ReadLine();
                var secondWord = Console.ReadLine();

                var maxWord = GetMax(firstWord, secondWord);

                Console.WriteLine(maxWord);
            }
        }

        private static string GetMax(string firstWord, string secondWord)
        {
            var result = string.Empty;

            if (firstWord.CompareTo(secondWord) > 0)
            {
                result = firstWord;
            }

            result = secondWord;

            return result;
        }

        private static char GetMax(char firstSymbol, char secondSymbol)
        {
            var result = ' ';

            if (firstSymbol.CompareTo(secondSymbol) > 0)
            {
                result = firstSymbol;
            }

            result = secondSymbol;

            return result;
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            var result = 0;

            if (firstNumber > secondNumber)
            {
                result = firstNumber;
            }

            else if (secondNumber > firstNumber)
            {

                result = secondNumber;

            }

            return result;
        }
    }
}
