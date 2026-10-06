using System;
using System.Collections.Generic;
using System.Text;

namespace AccessDemo2
{
    internal struct Student
    {
        int studentId;
        string studentName;
        void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {studentId}, Student Name: {studentName}");
        }
        static void Main()
        {
            try
            {
                Student s = new Student();
                s.studentId = 1;
                s.studentName = "John Doe";
                s.DisplayStudentInfo();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");

            }
        }
    }
}
