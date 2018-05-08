namespace _10.VariableInHexadecimalFormat
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = (Console.ReadLine());

            int variable = Convert.ToInt32(input, 16);

            Console.WriteLine(variable);
        }
    }
}
