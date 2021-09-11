using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name {get; private set;}

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
                Console.WriteLine("Insert in correct range");
        

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
                result.Avarage = result.Avarage + grade;
            }

            /*var index = 0;
            do
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Avarage = result.Avarage + grades[index];
                index += 1;
            }
            while (index < grades.Count);*/

            result.Avarage = result.Avarage / grades.Count;

            switch (result.Avarage)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >=75.0 && d < 90.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 65.0 && d < 75.0:
                    result.Letter = 'B';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }


    }
}