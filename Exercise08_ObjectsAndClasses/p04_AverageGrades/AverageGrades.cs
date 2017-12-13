using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                List<double> grades = new List<double>();
                foreach (var grade in input.Skip(1))
                {
                    grades.Add(double.Parse(grade));
                }
                students.Add(new Student { Name = input[0], Grades = grades });
            }

            foreach (Student student in students.Where(x => x.Average >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Average))
            {
                Console.WriteLine($"{student.Name} -> {student.Average:F2}");
            }

        }

        public class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double Average => Grades.Average();
        }
    }
}

