using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_AverageStudentGrades
{
    public class AverageStudentGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (studentGrades.ContainsKey(name))
                {
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name] = new List<double>() { grade };
                }
            }

            foreach (var student in studentGrades)
            {
                string name = student.Key;
                List<double> grades = student.Value;
                Console.Write($"{name} -> ");
                foreach (var grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {grades.Average():F2})");
            }
        }
    }
}
