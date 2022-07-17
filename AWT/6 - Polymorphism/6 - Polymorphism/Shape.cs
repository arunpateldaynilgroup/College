using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Polymorphism
{
    abstract class Shape
    {
        public double length, breath;
        public void set(double a =0.0 , double b =0.0)
        {
            length= a;
            breath= b;
        }

        public abstract double getArea();
    }
}
