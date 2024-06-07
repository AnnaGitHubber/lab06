using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class RectSolid : Solid
    {
        public double C { get; set; }
        public double D { get; set; }
        public double H { get; set; }

        public RectSolid(double c, double d, double h)
        {
            C = c;
            D = d;
            H = h;
        }

        public override double GetVolume()
        {
            return C * D * H;
        }
    }
}
