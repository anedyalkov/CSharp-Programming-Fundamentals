namespace _01.Register_Users
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var registeredUsers = new Dictionary<string, DateTime>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputLineElem = inputLine.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var name = inputLineElem[0];
                var date = DateTime.ParseExact(inputLineElem[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                registeredUsers[name] = date;

                inputLine = Console.ReadLine();
            }

            var sortedUsers = registeredUsers
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var userRegistrationDayPair in sortedUsers)
            {
                var username = userRegistrationDayPair.Key;
                var dayOfRegistration = userRegistrationDayPair.Value;

                Console.WriteLine("{0}", username);
            }
        }
    }
}
