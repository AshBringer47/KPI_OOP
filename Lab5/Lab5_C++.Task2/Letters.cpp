#include "Letters.h"

Letters::Letters(string Row) : Row(Row) { 
	try
	{
		for (auto& i : Row)
			if (isdigit(i))
				throw exception("Digits in Letters constructor");
	}
	catch (const std::exception& ex)
	{
		cout << ex.what() << endl;
		throw ex;
	}
}

void Letters::Remove(char ch) {
	string temp;
	for (auto& i : _Row) {
		if (i == ch)
			continue;
		temp.push_back(i);
	}
	_Row = temp;
}
