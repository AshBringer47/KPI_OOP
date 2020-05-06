#pragma once
#include <cmath>
class Expression
{
private:
	double _a, _c, _d;
public:
	Expression(double, double, double); // constructor of expression.
	double Calculate(); // method calculates our expression.
};
