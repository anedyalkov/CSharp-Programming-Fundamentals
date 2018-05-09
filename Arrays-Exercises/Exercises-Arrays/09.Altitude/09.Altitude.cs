namespace _09.Altitude
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var initialAltitude = double.Parse(input[0]);

            bool isCrashed = false;

            for (int i = 1; i < input.Length - 1; i++)
            {

                if (input[i] == "up")
                {
                    if (double.TryParse(input[i + 1], out double number))
                    {
                        initialAltitude += double.Parse(input[i + 1]);
                    }
                }

                else if (input[i] == "down")
                {
                    if (double.TryParse(input[i + 1], out double number))
                    {
                        initialAltitude -= double.Parse(input[i + 1]);
                    }
                }

                if (initialAltitude <= 0)
                {
                    isCrashed = true;
                    break;
                }
            }

            if (isCrashed)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine("got through safely. current altitude: {0}m", initialAltitude);
            }
        }
    }
}
