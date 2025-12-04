using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.week6
{
    public class Student
    {
        public string Name { get; set; }
        public string StudentId { get; set; }
        public double GPA { get; set; }

        public Student(string name, string studentId, double gpa)
        {
            Name = name;
            StudentId = studentId;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"{Name} (ID: {StudentId}, GPA: {GPA})";
        }
    }
}