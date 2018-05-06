namespace _12.ASCII_String
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            //var input = int.Parse(Console.ReadLine());
            //var sb = new StringBuilder();

            //for (int i = 0; i < input; i++)
            //{
            //    var asciiCode = int.Parse(Console.ReadLine());

            //    sb.Append((char)(asciiCode));
            //}

            //Console.WriteLine(sb.ToString());

            var number = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < number; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                word += (char)currentNumber;
            }

            Console.WriteLine(word);
        }
    }
}
