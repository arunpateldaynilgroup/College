using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___single_inhertance
{
    class AddInfo:BasicInfo
    {
        public string course;
        public int year;
        public int sem;

        public AddInfo() { }

        public AddInfo(string firstName, string middleName, string lastName, string course, int year, int sem)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.course = course;
            this.year = year;
            this.sem = sem;
        }

        public string addInfoToString()
        {
            return "\nCourse Name : " + course + " Semester : " + sem + " Year : " + year;
        }
    }
}
