using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsProject
{
    internal class Employee
    {
        int _EmpNo;
        string _EmpName, _Job;
        double _EmpSalary;

        public Employee(int eno)
        {
            _EmpNo = eno;
            _EmpName = "Not Assigned";
            _Job = "Not Assigned";
            _EmpSalary = 0.0;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return _EmpNo;
                else if (index == 1)
                    return _EmpName;
                else if (index == 2)
                    return _Job;
                else if (index == 3)
                    return _EmpSalary;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    _EmpNo = (int)value;
                else if (index == 1)
                    _EmpName = (string)value;
                else if (index == 2)
                    _Job = (string)value;
                else if (index == 3)
                    _EmpSalary = (double)value;
            }

        }
        public object this[string name]
        {
            get
            {
                if (name.ToLower() == "empno")
                    return _EmpNo;
                else if (name.ToLower() == "empname")
                    return _EmpName;
                else if (name.ToUpper() == "JOB")
                    return _Job;
                else if (name.ToLower() == "empsalary")
                    return _EmpSalary;
                else
                    return null;
            }
            set
            {
                if (name.ToLower() == "empno")
                    _EmpNo = (int)value;
                else if (name.ToLower() == "empname")
                    _EmpName = (string)value;
                else if (name.ToLower() == "job")
                    _Job = (string)value;
                else if (name.ToLower() == "empsalary")
                    _EmpSalary = (double)value;
            }
        }
    }
}
