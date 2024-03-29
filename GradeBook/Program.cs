﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;
            foreach(var number in grades)
            {
                result = result + number;
            }

            result = result / grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");

            Console.ReadLine();
        }
    }
}
