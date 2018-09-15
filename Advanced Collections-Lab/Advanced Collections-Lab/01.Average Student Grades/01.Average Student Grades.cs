namespace _01.Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var name = input[0];
                var grade = double.Parse(input[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades[name] = new List<double>();
                }

                studentsGrades[name].Add(grade);
            }

            foreach (var studentGrades in studentsGrades)
            {
                var student = studentGrades.Key;
                var grades = studentGrades.Value;

                var averageGrade = grades.Average();

                Console.Write($"{student} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {averageGrade:F2})");
            }

        }
    }
}
