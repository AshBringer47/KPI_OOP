#include <iostream>
#include <cmath>
#include <string>

using namespace std;

int sumarize(int, int); // returns via value.
void sumarize(int, int, int&); // returns via parameter.
bool lessThan(int, int); // returns via value.
void lessThan(int, int, bool&); // returns via parameter.
int max(int, int); // finds the greatest number.
string toBinary(int); // converts number into binary.

int main() {
	bool flag = false;
	int sum = 0;
	int a, b;
	cin >> a >> b;
	cout << sumarize(a, b);
	cout << endl << lessThan(a, b);
	return 0;
}

int sumarize(int x, int y) {
	int sum = x ^ y;
	int carry = x & y;
	while (carry) {
		carry = carry << 1;
		x = sum;
		y = carry;
		sum = x ^ y;
		carry = x & y;
	}
	return sum;
}

void sumarize(int x, int y, int &result) {
	int sum = x ^ y;
	int carry = x & y;
	while (carry > 0) {
		carry = carry << 1; // Move all bits on 1 on right.
		x = sum;
		y = carry;
		sum = x ^ y; // Sum bits.
		carry = x & y; // Invert all the bits.
	}
	result = sum;
	return;
}

bool lessThan(int x, int y) {
	int length = toBinary(abs(max(x, y))).length(); // Finds the longest number in term of bits.
	for (int j = length; j >= 0; j--)
	{
		if ((x & (x << j)) < (y & (y << j)))
		{
			return true;
		}
	}
	return false;
}

void lessThan(int x, int y, bool& flag) {

	int length = toBinary(abs(max(x, y))).length();
	for (int j = length; j >= 0; j--)
	{
		if ((x & (x << j)) < (y & (y << j)))
		{
			flag = true;
			return;
		}
	}
	flag = false;
	return;
}

int max(int x, int y) {
	return x > y ? x : y;
}

string toBinary(int x) {
	string binary = "";
	binary.insert(0, to_string(x % 2));
	x /= 2;
	while (x) {
		binary.insert(0, to_string(x % 2));
		x /= 2;
	}
	return binary;
}
