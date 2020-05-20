#include <iostream>
#include <string>

using namespace std;

int FirstChar(string, char); // entrance of first symbol.

int main() {
	cout << "Gunawardana Shiron. IS92\n";
	string str;
	char ch;
	cout << "Enter your string: ";
	getline(cin, str);
	cout << "Enter your char: ";
	cin >> ch;
	int (*funcPtr)(string, char) = FirstChar; // creating function pointer and assign it on the FirstChar.
	int indexPtr = funcPtr(str, ch); // via pointer function.
	int index = FirstChar(str, ch); // via function.
	cout << "Pointer function value: " << indexPtr << "\nFunction value: " << index;
	return 0;
}

int FirstChar(string str, char ch) {
	return str.find_first_of(ch);
}