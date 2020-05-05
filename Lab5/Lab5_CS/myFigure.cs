using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_CS
{
    class myFigure
    {
        protected double[,] _Coordinates;
        protected int Dots;
        public myFigure(int size, double[] XCoord, double[] YCoord, double[] ZCoord)
        {
            Dots = size;
            _Coordinates = new double[size, 3];
            for(int i = 0; i < size; i++)
            {
                _Coordinates[i, 0] = XCoord[i];
                _Coordinates[i, 1] = YCoord[i];
                _Coordinates[i, 2] = ZCoord[i];
            }
        }
        public double sideLength(int number)
        {
            double sideLength = 0;
            if (number != Dots)
            {
                for(int i = 0; i < 3; i++)
                {
                    sideLength += Math.Pow(_Coordinates[number, i] - _Coordinates[number - 1, i], 2); // Finds length of every side except for the last.
                }
                return Math.Sqrt(sideLength); 
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    sideLength += Math.Pow(_Coordinates[number - 1, i] - _Coordinates[0, i], 2); // Finds length of the last side.
                }
                return Math.Sqrt(sideLength);
            }
        }
        public int Len()
        {
            return Dots;
        }
    }
}
