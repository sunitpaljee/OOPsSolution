using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsProject
{
    internal class TestEmployee
    {
        static void Main()
        {
            Employee emp = new Employee(101);
            //emp[1] = "Aman";
            //emp[2] = "Manager";
            //emp[3] = 10000.00;
            Console.WriteLine("Employee No: {0}", emp[0]);
            Console.WriteLine("Employee Name: {0}", emp[1]);
            Console.WriteLine("Employee Job: {0}", emp[2]);
            Console.WriteLine("Employee Salary: {0}", emp[3]);
            Console.WriteLine("Employee No: {0}", emp["empno"]);
            Console.WriteLine("Employee Name: {0}", emp["empname"]);
            Console.WriteLine("Employee Job: {0}", emp["job"]);
            Console.WriteLine("Employee Salary: {0}", emp["empsalary"]);

            Console.WriteLine("--------------------------------");
            Employee emp1 = new Employee(102);
            emp1[2] = "Software Engineer";
            emp1[1] = "Muizun";
            emp1["emPSalary"] = 20000.00;
            Console.WriteLine(emp1["jOB"]);
            Console.WriteLine(emp1[0]);
            Console.WriteLine(emp1[1]);
            Console.WriteLine(emp1[2]);
            Console.WriteLine(emp1[3]);

        }
    }
}
