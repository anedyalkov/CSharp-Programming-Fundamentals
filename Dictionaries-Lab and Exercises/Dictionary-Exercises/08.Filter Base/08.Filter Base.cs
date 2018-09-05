using System;
namespace _08.Filter_Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var ageDict = new Dictionary<string, int>();
            var salaryDict = new Dictionary<string, double>();
            var positionDict = new Dictionary<string, string>();

            while (input != "filter base")
            {
                var inpuLineElements = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var name = inpuLineElements[0];
                var secondElement = inpuLineElements[1];

                var numberIsInt = 0;
                var numberIsDouble = 0.0;

                if (int.TryParse(secondElement, out numberIsInt))
                {
                    ageDict[name] = int.Parse(secondElement);
                }

                else if (double.TryParse(secondElement, out numberIsDouble))
                {
                    salaryDict[name] = double.Parse(secondElement);
                }

                else
                {
                    positionDict[name] = secondElement;
                }



                input = Console.ReadLine();
            }

            var entry = Console.ReadLine();

            if (entry == "Age")
            {
                foreach (var nameAgePair in ageDict)
                {
                    var name = nameAgePair.Key;
                    var age = nameAgePair.Value;

                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine("====================");
                }

            }

            else if (entry == "Salary")
            {
                foreach (var nameSalaryPair in salaryDict)
                {
                    var name = nameSalaryPair.Key;
                    var salary = nameSalaryPair.Value;

                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Salary: {salary:F2}");
                    Console.WriteLine("====================");
                }
            }

            else if (entry == "Position")
            {
                foreach (var namePositionPair in positionDict)
                {
                    var name = namePositionPair.Key;
                    var position = namePositionPair.Value;

                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Position: {position}");
                    Console.WriteLine("====================");
                }
            }

        }
    }
}
