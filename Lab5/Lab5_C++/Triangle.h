#pragma once
#include "myFigure.h"
#include <cmath>

class Triangle : myFigure
{
	Triangle(int, double*, double*, double*);
	double Square();
	double Perimeter();
	double* Coordinates(int);
};

