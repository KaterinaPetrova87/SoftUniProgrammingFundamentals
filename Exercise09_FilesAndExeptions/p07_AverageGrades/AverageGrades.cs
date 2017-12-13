using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p08_AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            List<Student> students = GatherstudentData();
            students = students
                .Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenBy(x => x.AverageGrade)
                .ToList();

            StudentsToFile(students);
        }

        private static void StudentsToFile(List<Student> students)
        {
            File.WriteAllLines("../../output.txt", students.Select(x => $"{x.Name} -> {x.AverageGrade:F2}").ToList());
        }

        private static List<Student> GatherstudentData()
        {
            string[] studentGrades = File.ReadAllLines("../../input.txt");
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentGrades.Length; i++)
            {
                string[] currentStudent = studentGrades[i].Split(' ');
                string name = currentStudent[0];
                List<double> grades = currentStudent.Skip(1).Select(double.Parse).ToList();

                students.Add(new Student { Name = name, Grades = grades });
            }

            return students;
        }
        public class Student
        {
            public string Name { get; set; }

            public List<double> Grades { get; set; }

            public double AverageGrade => this.Grades.Average();
        }
    }
}
