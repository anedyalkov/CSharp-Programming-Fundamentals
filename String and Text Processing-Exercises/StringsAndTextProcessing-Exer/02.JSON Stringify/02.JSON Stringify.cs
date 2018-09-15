namespace JSON_stringify_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }

    }
    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "stringify")
                {
                    break;
                }

                var inputElements = input.Split(":->, ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var name = inputElements[0];
                var age = int.Parse(inputElements[1]);
                List<int> grades = inputElements.Skip(2).Select(int.Parse).ToList();

                Student newStudent = new Student();

                newStudent.Name = name;
                newStudent.Age = age;
                newStudent.Grades = grades;

                students.Add(newStudent);
            }
            var sb = new StringBuilder();
            var output = string.Empty;

            output += "[";

            for (int i = 0; i < students.Count; i++)
            {
                var currentStudent = students[i];


                output += "{";
                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.Grades) + "]";
                output += "}";
                if (i < students.Count - 1)
                {
                    output += ",";
                }
            }

            output += "]";

            Console.WriteLine(output);
        }
    }
}

