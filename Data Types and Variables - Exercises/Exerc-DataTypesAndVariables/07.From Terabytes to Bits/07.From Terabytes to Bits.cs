namespace _07.From_Terabytes_to_Bits
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double terrabytes = double.Parse(Console.ReadLine());
            Console.WriteLine(terrabytes * 1024 * 1024 * 1024 * 1024 * 8);
        }
    }
}
