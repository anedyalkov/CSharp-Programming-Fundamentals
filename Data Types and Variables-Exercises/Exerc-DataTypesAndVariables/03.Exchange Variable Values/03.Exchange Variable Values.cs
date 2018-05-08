namespace _03.Exchange_Variable_Values
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var aNew = b;
            var bNew = a;

            Console.WriteLine(aNew);
            Console.WriteLine(bNew);
        }
    }
}
