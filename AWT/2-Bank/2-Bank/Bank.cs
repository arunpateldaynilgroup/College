using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bank
{
    public class Bank
    {
        public double bal;

        public Bank()
        {
            bal = 0;
        }

        public double open(double openBal)
        {
            bal += openBal;
            return bal;
        }


        public double deposit(double openBal)
        {
            bal += openBal;
            return bal;
        }

        public double withdraw(double openBal)
        {
            bal -= openBal;
            return bal;
        }

        public double check()
        {
            return bal;
        }

    }
}
