namespace _04.Sort_Array_Using_Bubble_Sort
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1); // todo: write swap method
                        swapped = true;
                    }
                    
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", arr));

        }

        public static void Swap(int[] arr, int i, int v)
        {
            var temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
        }
    }
}
