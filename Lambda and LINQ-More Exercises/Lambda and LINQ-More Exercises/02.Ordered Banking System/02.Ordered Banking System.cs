namespace _02.Ordered_Banking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var bankAccounts = new Dictionary<string, Dictionary<string, decimal>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var inputParts = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var bank = inputParts[0];
                var account = inputParts[1];
                var balance = decimal.Parse(inputParts[2]);

                if (!bankAccounts.ContainsKey(bank))
                {
                    bankAccounts.Add(bank, new Dictionary<string, decimal>());
                }

                if (!bankAccounts[bank].ContainsKey(account))
                {
                    bankAccounts[bank].Add(account, balance);
                }
                else
                {
                    bankAccounts[bank][account] += balance;
                }

            }

            var orderedBankAccounts = bankAccounts
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Max(y => y.Value))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in orderedBankAccounts)
            {
                var bank = pair.Key;
                var accountBalance = pair.Value;

                accountBalance = accountBalance
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var kvp in accountBalance)
                {
                    var account = kvp.Key;
                    var balance = kvp.Value;

                    Console.WriteLine($"{account} -> {balance} ({bank})");
                }
            }
        }
    }
}
