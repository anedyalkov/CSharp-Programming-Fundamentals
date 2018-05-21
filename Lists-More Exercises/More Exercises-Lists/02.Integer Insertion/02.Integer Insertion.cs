using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
           

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var index = int.Parse(input[0].ToString());
                numbers.Insert(index, int.Parse(input));
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
