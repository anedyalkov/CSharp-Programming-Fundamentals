namespace _08.Traveling_At_Light_Speed
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double input = double.Parse(Console.ReadLine());

            var lightYear = 9450000000000;
            var speedOfLight = 300000;

            decimal secondsForLightYear = (decimal)input * (lightYear / speedOfLight);

            decimal minutes = secondsForLightYear / 60;
            secondsForLightYear %= 60;

            decimal hours = minutes / 60;
            minutes %= 60;

            decimal days = hours / 24;
            hours %= 24;

            decimal weeks = days / 7;
            days %= 7;

            Console.WriteLine("{0} weeks", (int)weeks);
            Console.WriteLine("{0} days", (int)days);
            Console.WriteLine("{0} hours", (int)hours);
            Console.WriteLine("{0} minutes", (int)minutes);
            Console.WriteLine("{0} seconds", (int)secondsForLightYear);
        }
    }
}
