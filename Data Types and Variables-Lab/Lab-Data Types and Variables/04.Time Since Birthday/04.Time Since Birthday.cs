﻿namespace _04.Time_Since_Birthday
{
    using System;

    public class Program
    {
        public static void Main()
        {
            byte years = byte.Parse(Console.ReadLine());

            int days = years * 365;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes.", years, days, hours, minutes);
        }
    }
}
