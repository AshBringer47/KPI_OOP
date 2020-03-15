#include "myClass.h"

myClass::myClass() {}
myClass::myClass(string newString) {
	_newString = newString;
}

myClass::myClass(const myClass& oldString) {
	_newString = oldString._newString;
}

string myClass::Get() {
	return _newString;
}

void myClass::Set(string newString) {
	_newString = newString;
}

int myClass::Length() {
	return _newString.length();
}

myClass myClass::operator+(const myClass& newString) {
	return (this->_newString + newString._newString);
}

myClass myClass::operator-(const char& symbol) {
	myClass temp; // temp string without symbol to remove.
	for (auto sym : this->_newString) {
		if (sym == symbol)
			continue;
		temp._newString += sym;
	}
	return temp;
}

