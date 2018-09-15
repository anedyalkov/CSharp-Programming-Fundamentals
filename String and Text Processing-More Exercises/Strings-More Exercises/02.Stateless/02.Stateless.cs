namespace Stateless
{
    using System;

    public class Stateless
    {
        public static void Main()
        {
            string input; 

            while ((input = Console.ReadLine()) != "collapse")
            {
                var state = input;
                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    var index = state.IndexOf(fiction);
                    if (index >= 0)
                    {
                        state = state.Replace(fiction, string.Empty);
                    }
                    fiction = fiction.Remove(0, 1);

                    if (fiction.Length > 0)
                    {
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }
                }

                if (state.Length > 0)
                {
                    Console.WriteLine(state);
                }
                else
                {
                    Console.WriteLine("(void)");
                }
            }
        }
    }
}

