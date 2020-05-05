#include "Triangle.h"

Triangle::Triangle(int size, double* XCoord, double* YCoord, double* ZCoord) : myFigure(size, XCoord, YCoord, ZCoord) { }

double Triangle::Square() {
    double p = 0;
    for (int i = 0; i < 3; i++)
        p += SideLength(i + 1) / 2;
    double S = sqrt(p);
    for (int i = 0; i < 3; i++)
        S *= sqrt(p - SideLength(i + 1));
    return S;
}

double Triangle::Perimeter() {
    double P = 0;
    for (int i = 0; i < 3; i++)
        P += SideLength(i + 1);
    return P;
}

double* Triangle::Coordinates(int index) {
    return new double[3]{ _Coordinates[index - 1][0], _Coordinates[index - 1][1], _Coordinates[index - 1][2] };
}
