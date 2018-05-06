namespace _02.Triples_of_Latin_Letters
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < input; i++)
            {
                char firstLetter = (char)('a' + i);

                for (int j = 0; j < input; j++)
                {
                    char secondLetter = (char)('a' + j);

                    for (int k = 0; k < input; k++)
                    {
                        char thirdLetter = (char)('a' + k);
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
