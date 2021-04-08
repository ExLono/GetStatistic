using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grades Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var stats = book.GetStatistic();

            Console.WriteLine($"The low value is: {stats.Low}");
            Console.WriteLine($"The high value is: {stats.High}");
            Console.WriteLine($"The avarege is {stats.Avarage:N1}");

        }
    }
}
