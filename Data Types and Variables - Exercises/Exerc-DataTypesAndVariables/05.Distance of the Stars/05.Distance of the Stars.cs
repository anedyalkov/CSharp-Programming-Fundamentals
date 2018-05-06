namespace _05.Distance_of_the_Stars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal distanceToTheNearestStar = 4.22m * 9450000000000;
            decimal distancetoTheCentergalaxy = 9450000000000 * 26000;
            decimal diameterOfMilkyWay = 9450000000000 * 100000;
            decimal distanceToTheEdgeOfuniverse = 9450000000000m * 46500000000;

            Console.WriteLine(distanceToTheNearestStar.ToString("e2"));
            Console.WriteLine(distancetoTheCentergalaxy.ToString("e2"));
            Console.WriteLine(diameterOfMilkyWay.ToString("e2"));
            Console.WriteLine(distanceToTheEdgeOfuniverse.ToString("e2"));
        }
    }
}
