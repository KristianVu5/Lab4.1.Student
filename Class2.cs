using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4._1.Student
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "John Doe";
            student.DateOfBirth = new DateTime(2000, 1, 1);
            Console.WriteLine("{0} is born on {1:dd.MM.yyyy}.", student.Name, student.DateOfBirth);
            Console.WriteLine("{0} is {1} years old.", student.Name, student.Age);
            Console.ReadLine();
        }
    }
}
