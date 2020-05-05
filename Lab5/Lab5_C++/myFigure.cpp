#include "myFigure.h"

myFigure::myFigure(int size, double* XCoord, double* YCoord, double* ZCoord) {
	_Dots = size;
	_Coordinates = new double* [size];
	for (auto i = 0; i < size; i++) {
		_Coordinates[i] = new double[3];
		_Coordinates[i][0] = XCoord[i];
		_Coordinates[i][1] = YCoord[i];
		_Coordinates[i][2] = ZCoord[i];
	}
}

double myFigure::SideLength(int index) {
	double sideLength = 0;
	if (index != _Dots) {
		for (int i = 0; i < 3; i++)
			sideLength += pow(_Coordinates[index][i] - _Coordinates[index - 1][i], 2);
		return sqrt(sideLength);
	}
	else {
		for (int i = 0; i < 3; i++)
			sideLength += pow(_Coordinates[index][i] - _Coordinates[0][i], 2);
		return sqrt(sideLength);
	}
}

int myFigure::Dots() {
	return _Dots;
}
