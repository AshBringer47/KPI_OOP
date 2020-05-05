#include "Row.h"

Row::Row(string Row) {
	_Row = Row;
}

string Row::Value() { return this->_Row; }

int Row::Length() { return this->_Row.length(); }

void Row::Remove(char ch) {
	string temp;
	for (auto& i : _Row) {
		if (i == ch)
			continue;
		temp.push_back(i);
	}
	_Row = temp;
}

