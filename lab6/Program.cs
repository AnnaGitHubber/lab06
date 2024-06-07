using System;
using System.Windows.Forms;
using lab6;

namespace lab6
{

    using System;
    using System.Windows.Forms;

    public abstract class Solid
    {
        public abstract double GetVolume();
    }
}
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
