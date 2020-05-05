#include <iostream>
#include <string>
#include "myFigure.h"

using namespace std;

int main() {
	int size;
	cin >> size;
	myFigure figure = myFigure(size, new double[size] { 1.4, 3.5, 4.4 }, new double[size] { 3.3, 2.0, 4.2 }, new double[size] { 2.5, 3.0, 2.6 });
	cout << figure.SideLength(2);
}