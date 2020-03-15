#include <iostream>
#include <string>
#include "myClass.h"
using namespace std;

int main() {
	myClass str1 = myClass(); // via default constructor.
	myClass str2 = myClass("hell##o# "); // via parameter constructor.
	myClass str3 = myClass(str2); // via copy constructor.
	str1 = str2 + str3; // "+" operator.
	cout << str1.Get();
	str1 = str1 - '#'; // "-" operator.
	cout << endl << str1.Get();
}