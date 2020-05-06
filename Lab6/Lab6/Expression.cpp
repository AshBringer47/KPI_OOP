#include "Expression.h"

Expression::Expression(double a, double c, double d) {
	_a = a;
	_c = c;
	_d = d;
}

double Expression::Calculate() {
	if (pow(_a, 2) == 1)
		throw "Divide by zero exception. Denominator = 0.";
	if (_d == 0)
		throw "Incorrect logarithmitic argument.";
	return (2 * _c - log10(_d / 4)) / (pow(_a, 2) - 1);
}
