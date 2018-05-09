namespace _10.Ballistics_Training
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var targetCoordinates = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

            var x = targetCoordinates[0];
            var y = targetCoordinates[1];

            var commands = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var newX = 0.0;
            var newY = 0.0;

            for (int i = 0; i < commands.Length; i++)
            {
                
                if (commands[i] == "right")
                {
                    if (double.TryParse(commands[i+1],out double number))
                    {
                        newX += number;
                        i++;
                    }
                }
                if (commands[i] == "left")
                {
                    if (double.TryParse(commands[i + 1], out double number))
                    {
                        newX -= number;
                        i++;
                    }
                }
                if (commands[i] == "up")
                {
                    if (double.TryParse(commands[i + 1], out double number))
                    {
                        newY += number;
                        i++;
                    }
                }
                if (commands[i] == "down")
                {
                    if (double.TryParse(commands[i + 1], out double number))
                    {
                        newY -= number;
                        i++;
                    }
                }
            }

            Console.WriteLine($"firing at [{newX}, {newY}]");

            if (newX == x && newY == y)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
