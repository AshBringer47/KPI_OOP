#pragma once
#include <cmath>

class myFigure
{
protected:
	int _Dots; // amount of dots in figure.
	double** _Coordinates; // array of figure's coordinates.
public:
	myFigure(int, double* XCoord, double* YCoord, double* ZCoord);
	double SideLength(int); // returns length of side by formula of square coordinates. Parameter represents side's number(starts from 1). 
	int Dots(); // returns number of dots.
};

