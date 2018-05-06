namespace _06.Increment_Variable
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int variable = int.Parse(Console.ReadLine());

            byte counter = 0;
            var overflow = 0;

            for (int i = 0; i < variable; i++)
            {

                counter++;
                if (counter == 0)
                {
                    overflow++;
                }

            }

            Console.WriteLine(counter);

            if (overflow > 0)
            {
                Console.WriteLine($"Overflowed {overflow} times");
            }

        }
    }
}
