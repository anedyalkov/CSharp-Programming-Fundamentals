namespace _04.Draw_a_Filled_Square
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            PrintFigure(size);
        }

        public static void PrintFigure(int size)
        {
            PrintHeaderBottomRow(size);
            PrintMiddleRow(size);
            PrintHeaderBottomRow(size);
        }

        public static void PrintMiddleRow(int size)
        {
            for (int i = 0; i < size - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < size; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        public static void PrintHeaderBottomRow(int size)
        {
            Console.WriteLine(new string('-', 2 * size));
        }
    }
}
