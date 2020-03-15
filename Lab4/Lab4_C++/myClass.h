#pragma once
#include <string>

using namespace std;

class myClass
{
private:
	string _newString;
public:
	myClass(); // default constructor.
	myClass(string); // parameter constructor.
	myClass(const myClass&); // copy constructor.
	string Get(); // getter of myClass value.
	void Set(string); // setter of myClass value.
	int Length(); // Length of myClass value.
	myClass operator +(const myClass&); // overloaded operator "+".
	myClass operator -(const char&); // overloaded operator "-".
};

