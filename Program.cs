using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grades Book");

            while (true)
            {
                Console.WriteLine("Enter a grade (0-100) or 'Q' to Statistic");
                var input = Console.ReadLine();

                if (input == "q" || input == "Q") { break; }
                try
                {
                    book.AddGrade(double.Parse(input));
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
            }

                /*book.AddGrade(89.1);
                book.AddGrade(90.5);
                book.AddGrade(77.3);*/

            var stats = book.GetStatistic();

            Console.WriteLine($"The low value is: {stats.Low}");
            Console.WriteLine($"The high value is: {stats.High}");
            Console.WriteLine($"The avarege is {stats.Avarage:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

            Console.ReadLine();

        }
    }
}
