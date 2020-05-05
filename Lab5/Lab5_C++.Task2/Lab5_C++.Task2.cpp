#include <iostream>
#include <string>
#include "Row.h"
#include "Numbers.h"
#include "Letters.h"

using namespace std;

int main() {
	cout << "Gunawardana Shiron. IS-92\nEnter your row: ";
	char a; // char to remove.
	string temp = ""; // string for constructors.
	getline(cin, temp);
	auto row = new Row(temp); // creating a Row object.
	cout << "Enter your numbers: ";
	getline(cin, temp);
	auto numbers = new Numbers(temp); // creating Numbers object.
	cout << "Enter your letters: ";
	getline(cin, temp);
	auto letters = new Letters(temp); // creating Letters object.
	cout << "\nRow:\nIts length = " << row->Length() << "\nEnter char to remove: ";
	cin >> a;
	row->Remove(a);
	cout << "\nString after formatting:\n" << row->Value() << "\n";
	cout << "\nNumbers:\nIts length = " << numbers->Length() << "\nEnter char to remove: ";
	cin >> a; // deleting custom char.
	numbers->Remove(a);
	cout << "\nString after formatting:\n" << numbers->Value() << "\nLetters:\nIts length = " << letters->Length();
	letters->Remove(); // deleting 'a'.
	cout << "\nString after formatting:\n" << letters->Value();
	return 0;
}