namespace _04.Phone
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            var phoneNumbers = Console.ReadLine()
               .Split(' ')
               .ToArray();

            var names = Console.ReadLine()
               .Split(' ')
               .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "done")
            {
                var inputArgs = input.Split(' ').ToArray();

                var command = inputArgs[0];
                var nameOrNumber = inputArgs[1];
               
                if (command == "call")
                {
                    if (char.IsDigit(nameOrNumber[1]))
                    {
                        CallByNumber(phoneNumbers, names, nameOrNumber);
                    }
                    else
                    {
                        CallByName(phoneNumbers, names, nameOrNumber);
                    }
                }
                else if (command == "message")
                {
                    if (char.IsDigit(nameOrNumber[1]))
                    {
                        SendMessageToNumber(phoneNumbers, names, nameOrNumber);
                    }
                    else
                    {
                        SendMessageToName(phoneNumbers, names, nameOrNumber);
                    }
                }
            }
        }

        private static void SendMessageToName(string[] phoneNumbers, string[] names, string nameOrNumber)
        {
            var name = nameOrNumber;
            string number;
            for (int i = 0; i < names.Length; i++)
            {
                if (name == names[i])
                {
                    number = phoneNumbers[i];
                    Console.WriteLine($"sending sms to {number}...");

                    int difference = GetDifferenceOfDigits(number);

                    PrintMessageCommand(difference);
                }
            }
        }

        private static void SendMessageToNumber(string[] phoneNumbers, string[] names, string nameOrNumber)
        {
            var number = nameOrNumber;

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (number == phoneNumbers[i])
                {
                    var name = names[i];
                    Console.WriteLine($"sending sms to {name}...");

                    int difference = GetDifferenceOfDigits(number);

                    PrintMessageCommand(difference);
                }
            }
        }

        private static void CallByName(string[] phoneNumbers, string[] names, string nameOrNumber)
        {
            var name = nameOrNumber;
            string number;
            for (int i = 0; i < names.Length; i++)
            {
                if (name == names[i])
                {
                    number = phoneNumbers[i];
                    Console.WriteLine($"calling {number}...");

                    int sum = GetSumOfDigits(number);
                    PrintCallingComand(sum);
                }
            }
        }

        private static void CallByNumber(string[] phoneNumbers, string[] names, string nameOrNumber)
        {
            var number = nameOrNumber;

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (number == phoneNumbers[i])
                {
                    var name = names[i];
                    Console.WriteLine($"calling {name}...");

                    int sum = GetSumOfDigits(number);
                    PrintCallingComand(sum);
                }
            }
        }

        private static void PrintMessageCommand(int difference)
        {
            if (Math.Abs(difference) % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }

        private static int GetDifferenceOfDigits(string number)
        {
            int difference = 0;
            for (int j = 0; j < number.Length; j++)
            {
                if (number[j] >= 48 && number[j] <= 57)
                {
                    difference -= int.Parse(number[j].ToString());
                }
            }

            return difference;
        }

        private static void PrintCallingComand(int sum)
        {
            if (sum % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                var minutes = sum / 60;
                var seconds = sum % 60;
                Console.WriteLine($"call ended. duration: {minutes.ToString("D2")}:{seconds.ToString("D2")}");
            }
        }

        private static int GetSumOfDigits(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                if (digit >= 48 && digit <= 57)
                {
                    sum += int.Parse(digit.ToString());
                }
            }

            return sum;
        }
    }
}


