using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new DiskBook("Scott's Grade Book");


            // My logic
            /*Console.WriteLine("How much grades you want insert?");
            var num =int.Parse(Console.ReadLine());
            while(num != 0)
            {
                Console.Write("Enter the grade: ");
                book.AddGrade(double.Parse(Console.ReadLine()));
                num--;
            } */

            // Scott's logic

            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }

        private static void EnterGrades(Book book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("**Added succesfully**");
                }
            }
        }
    }
}

    
