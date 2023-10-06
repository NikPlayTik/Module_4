using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    public interface IStudent
    {
        double CalculateAVG();
        string GetCourseInfo();
    }

    // Класс для представления студента
    public class Student : IStudent
    {
        private string name;
        private int course;
        private double[] grades;

        public Student(string name, int course, double[] grades)
        {
            this.name = name;
            this.course = course;
            this.grades = grades;
        }

        public double CalculateAVG()
        {
            if (grades.Length == 0)
            {
                return 0.0;
            }

            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }

            return sum / grades.Length;
        }

        public string GetCourseInfo()
        {
            return $"{name}, учащийся {course} курса";
        }
    }

    public class StudentAccouting
    {
        public void Student()
        {
            Student student1 = new Student("Никита Анищенко", 1, new double[] { 9.5, 10, 9.0 });
            Student student2 = new Student("Рафаэль Санти", 3, new double[] { 8.8, 9.2, 9.9 });

            // вывод информации о студентах
            Console.WriteLine(student1.GetCourseInfo());
            Console.WriteLine($"Средний балл: {student1.CalculateAVG():F2}");

            Console.WriteLine(student2.GetCourseInfo());
            Console.WriteLine($"Средний балл: {student2.CalculateAVG():F2}");
            Console.ReadLine();
        }
    }
}