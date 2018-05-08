namespace _13.Calculator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstOperand = int.Parse(Console.ReadLine());
            string oprerator = (Console.ReadLine()); ;
            var secondOperand = int.Parse(Console.ReadLine());
            var equality = "=";
            var sum = 0;


            switch (oprerator)
            {
                case "+":
                    sum = firstOperand + secondOperand;
                    Console.WriteLine("{0} {1} {2} {3} {4}", firstOperand, oprerator, secondOperand, equality, sum);
                    break;
                case "-":
                    sum = firstOperand - secondOperand;
                    Console.WriteLine("{0} {1} {2} {3} {4}", firstOperand, oprerator, secondOperand, equality, sum);
                    break;
                case "*":
                    sum = firstOperand * secondOperand;
                    Console.WriteLine("{0} {1} {2} {3} {4}", firstOperand, oprerator, secondOperand, equality, sum);
                    break;
                case "/":
                    sum = firstOperand / secondOperand;
                    Console.WriteLine("{0} {1} {2} {3} {4}", firstOperand, oprerator, secondOperand, equality, sum);
                    break;

            }

        }
    }
}
