namespace _04.Rotate_Array_of_Strings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .ToArray();

            var rotatedArray = new string[array.Length];

            rotatedArray[0] = array[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                rotatedArray[i] = array[i - 1];
            }

            Console.WriteLine(string.Join(" ",rotatedArray));
        }
    }
}
