using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_ArrayUsingInsertionSort
{
    public class Program
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            for (int firstUnsorted = 0; firstUnsorted < arr.Length - 1; firstUnsorted++)
            {
                var i = firstUnsorted + 1;
                while (i > 0)
                {
                    if (arr[i - 1] > arr[i])
                        Swap(arr, i, i - 1); // todo: write Swap() method
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        private static void Swap(int[] arr, int i, int v)
        {
            var temp = arr[i];
            arr[i] = arr[i - 1];
            arr[i - 1] = temp;
        }
    }
}
