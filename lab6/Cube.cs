using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Cube : Solid
    {
        public double A { get; set; }

        public Cube(double a)
        {
            A = a;
        }

        public override double GetVolume()
        {
            return Math.Pow(A, 3);
        }
    }
}
