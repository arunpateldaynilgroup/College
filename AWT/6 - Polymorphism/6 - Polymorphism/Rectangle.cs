using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Polymorphism
{
    class Rectangle : Shape
    {
        public override double getArea()
        {
            return length * breath;
        }

    }
}
