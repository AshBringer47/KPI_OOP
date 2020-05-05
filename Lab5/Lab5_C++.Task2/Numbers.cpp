#include "Numbers.h"

Numbers::Numbers(string Row) : Row(Row) {
	try
	{
		for (auto& i : Row)
			if (isalpha(i))
				throw exception("Letters in Numbers constructor");
	}
	catch (const std::exception& ex)
	{
		cout << ex.what() << endl;
		throw ex;
	}
}

void Numbers::Remove(char ch) {
	string temp;
	for (auto& i : _Row) {
		if (i == ch)
			continue;
		temp.push_back(i);
	}
	_Row = temp;
}