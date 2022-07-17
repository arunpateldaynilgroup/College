using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___single_inhertance
{
    class BasicInfo
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public BasicInfo() { }
        public BasicInfo(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public string baseInfoToString()
        {
            return "Welcome " + firstName + " " + middleName + " " + lastName;
        }
    }
}
