#include "pch.h"
#include "framework.h"
#include <string>
#include <vector>
#include <cassert>
#include <iostream>
using namespace std;

namespace mySpace { // Constructor
    myString::myString(char* newString) {
        myString::Set(newString);
    }

    char* myString::Get() { // Getter.
        return _newString; 
    }

    void myString::Set(char* newString) { // Setter.
        _newString = newString;
    }

    int myString::stringLength() {
        return strlen(_newString);
    }
	void myText::addString(myString newString) {
		_newText.push_back(newString);
	}

	void myText::removeString(int index) {
		if (index - 1 > _newText.size()) {
			assert("Wrong index");
			cerr << "\nWrong index";
		}

		_newText.erase(_newText.begin() + index - 1);
	}

	void myText::erase() {
		_newText.clear();
	}

	int myText::shortestRow() {
		int min = _newText[0].stringLength();
		for (auto i = 0; i < _newText.size(); i++) {
			min = (_newText[i].stringLength() < min) ? _newText[i].stringLength() : min;
		}
		return min;
	}

	double myText::consonantPercentage() {
		int consonants = 0;
		int symbols = 0;
		for (int i = 0; i < _newText.size(); i++) {
			for (int j = 0; j < _newText[i].stringLength(); j++) {
				if (_newText[i].Get()[j] == ' ') {
					continue;
				}
				if (consonantCheck(_newText[i].Get()[j])) {
					consonants++;
				}
				symbols++;
			}
		}
		return((double)(consonants / symbols) * 100);
	}

	bool myText::consonantCheck(char symbol) {
		vector <char> consonants = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
		if (count(consonants.begin(), consonants.end(), symbol)) {
			return true;
		}
		else {
			return false;
		}
	}

	void myText::spaceClean(int index) {
		vector <char> temp;
		int _index = 0; // Index of first non-space element.
		while (_newText[index].Get()[_index]) {
			_index++;
		}
		for (int i = _index; i < _newText[index].stringLength(); i++) {
			if (_newText[index].Get()[i] == ' ') {
				if (_newText[index].Get()[i - 1] != ' ') {
					temp.push_back(_newText[index].Get()[i]);
					continue;
				}
				else {
					continue;
				}
			}
			temp.push_back(_newText[index].Get()[i]);
		}
		if (_newText[index].Get()[_newText[index].stringLength()] == ' ') {
			temp.pop_back();
		}
		char* newTemp = new char[temp.size()];
		for (int i = 0; i < temp.size(); i++) {
			newTemp[i] = temp[i];
		}
		_newText[index].Set(newTemp);
	}

	char* myText::Get(int index) {
		return _newText[index].Get();
	}
}


