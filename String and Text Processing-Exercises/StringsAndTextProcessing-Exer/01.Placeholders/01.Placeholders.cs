namespace _01.Placeholders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var tokens = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var someString = tokens[0];
                var someElements = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                var index = 0;

                for (int i = 0; i < someElements.Count; i++)
                {
                    var currentPlaceholder = i;
                    var currentElement = someElements[i];
                    index = someString.IndexOf("{" + currentPlaceholder + "}", index);
                    if (index < 0)
                    {
                        break;
                    }
                    string placeholder = someString.Substring(index, 3);
                    someString = someString.Replace(placeholder, currentElement);
                    index = 0;                 
                }

                Console.WriteLine(someString);
            }
        }
    }
}
