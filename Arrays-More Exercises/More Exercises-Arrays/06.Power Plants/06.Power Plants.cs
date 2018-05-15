namespace _06.Power_Plants
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var plantsPower = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var n = plantsPower.Length;

            var isAlive = true;
            var days = 0;
            var season = -1;

            while (isAlive)
            {
                season++;
                var dayIndex = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j != dayIndex)
                        {
                            if (plantsPower[j] > 0)
                            {
                                plantsPower[j]--;
                            }
                        }
                    }
                    dayIndex++;
                    days++;

                    var sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        sum += plantsPower[j];
                    }

                    if (sum == 0)
                    {
                        isAlive = false;
                        break;
                    }
                    sum = 0;
                }

                for (int i = 0; i < n; i++)
                {
                    if (plantsPower[i] > 0)
                    {
                        plantsPower[i]++;
                    }
                }
            }
            var seasonString = season == 1 ? "season" : "seasons";

            Console.WriteLine($"survived {days} days ({season} {seasonString})");
        }
    }
}
