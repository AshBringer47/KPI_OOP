using System;

namespace Lab5_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gunawardana Shiron. IS92");
            Triangle triangle = new Triangle(new double[] { 3.0, 4.0, 5.0 }, new double[] { 1.0, 6.0, 4.0 }, new double[] { 5.0, 10.0, 9.0 });
            Console.WriteLine(triangle.sideLength(1));
            Console.WriteLine(triangle.Square());
            Console.WriteLine(triangle.Perimeter());
            double[] firstDot = triangle.DotCoordinates(1);
            foreach(int Coord in firstDot)
                Console.WriteLine(Coord);
        }
    }
}
