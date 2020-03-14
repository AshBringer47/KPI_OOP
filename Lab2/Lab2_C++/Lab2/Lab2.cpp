#include <iostream>
#include <string>
#include <vector>
#include "../myClasses/pch.h"

using namespace std;
using namespace mySpace;

int main() {
	cout << "Gunawardana Shiron. IS92.\n";
	char* abc = new char[100];
	cin >> abc;
	myString str = myString(abc);
	myText text = myText();
	text.addString(str);
	cout << text.Get(0);
	text.removeString(3);
	
}