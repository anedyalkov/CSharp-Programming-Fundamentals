namespace _03.Greeting
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {secondName}. You are {age} years old.");
        }
    }
}
