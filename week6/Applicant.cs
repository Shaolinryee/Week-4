using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.week6
{
    public class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string CitizenshipNumber { get; set; }

        public Applicant(string name, int age, string citizenshipNumber)
        {
            Name = name;
            Age = age;
            CitizenshipNumber = citizenshipNumber;
        }

        public override string ToString()
        {
            return $"{Name} (Age: {Age}, Citizenship: {CitizenshipNumber})";
        }
    }
}