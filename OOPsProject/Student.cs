using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsProject
{
    internal class Student
    {
        int _SNo=100;
        string _SName="Muizun", _Address;
        float _Fee;
        bool _isActive;
        public int SNo
        {
            get { return _SNo; }
            set { _SNo = value; }
        }
        public string SName 
        {
            get { return _SName; }
            set { _SName = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public float Fee
        {
            get { return _Fee; }
            set { _Fee = value; }
        }
        // public bool ISActive { get; set; }
        public bool ISActive 
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        public Student(int sno)
        {
            _SNo = sno;
            _SName = "Manas";
            _Address = "Bhubanaswar";
            _Fee = 30000f;
            _isActive = true;
        }
        public override string ToString()
        {
            return ("SNo " + _SNo+ "\nName : " + _SName + 
                "\nAddress : " + _Address + "\nFees : " + 
                _Fee + "\nStatus :" + _isActive);
        }
    }
}
