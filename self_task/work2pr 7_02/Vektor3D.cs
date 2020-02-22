using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vektor
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vektor3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double VektorLength()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public double Scalar(Vektor3D v2)
        {
            return (X * X) + (Y * Y) + (Z * Z);
        }

        public Vektor3D VecComposition(Vektor3D v2)
        {
            Vektor3D res = new Vektor3D(5, 12, 24);

            res.X = (Y * v2.Z) - (Z * v2.Y);
            res.Y = (Z * v2.X) - (X * v2.Z);
            res.Z = (X * v2.Y) - (Y * v2.X);

            return res;
        }

        public override string ToString()
        {
            return $"vec (X: {X}, Y: {Y}, Z:{Z})";
        }
    }
}
