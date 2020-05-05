using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_CS
{
    class Triangle : myFigure
    {
        public Triangle(double[] XCoord, double[] YCoord, double[] ZCoord) : base(3, XCoord, YCoord, ZCoord)
        {
        }
        public double Square()
        {
            double p = 0;
            for(int i = 0; i < 3; i++)
            {
                p += this.sideLength(i + 1) / 2;
            }
            double S = Math.Sqrt(p);
            for(int i = 0; i < 3; i++)
            {
                S *= Math.Sqrt(p - this.sideLength(i + 1));
            }
            return S;
        }
        public double Perimeter()
        {
            double P = 0;
            for (int i = 0; i < 3; i++)
            {
                P += this.sideLength(i + 1);
            }
            return P;
        }
        public double[] DotCoordinates(int index)
        {
            return new double[3] { _Coordinates[index - 1, 0], _Coordinates[index - 1, 1], _Coordinates[index - 1, 2] };
        }
    }
}
