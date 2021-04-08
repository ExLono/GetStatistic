using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistic GetStatistic()
        {
            var result = new Statistic();
            result.Avarage = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);

                Console.Write(grade);
                Console.WriteLine();
                result.Avarage = result.Avarage + grade;
            }

            result.Avarage = result.Avarage / grades.Count;

            return result;
        }


    }
}