using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp66
{
    internal class Student
    {
        public static int No { get => _no; }
        static int _no;
        public string FullName { get; set; }
        public Student()
        {
            _no++;
        }
    }
}
