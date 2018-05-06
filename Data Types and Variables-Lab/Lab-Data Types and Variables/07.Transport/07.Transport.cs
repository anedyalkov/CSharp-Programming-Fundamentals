namespace _07.Transport
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var people = int.Parse(Console.ReadLine());

            var courses = (double)people / (8 + 4 + 12);

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
