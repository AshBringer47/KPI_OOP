#include <iostream>
#include <fstream>
#include "Expression.h"
#include "Log.h"

using namespace std;

int main() {
	double a, c, d;
	cout << "Gunawardana Shiron. IS92.\na = ";
	cin >> a;
	cout << "c = ";
	cin >> c;
	cout << "d = ";
	cin >> d;
	string name = "log.txt";
	auto log = Log(); // Log object to log an exception.
	auto expression = Expression(a, c, d);
	try {
		cout << expression.Calculate();
	}
	catch (const char* e) {
		cout << "Exception caught. Check out log.txt";
		log.LogException(e, name);
	}
	return 0;
}