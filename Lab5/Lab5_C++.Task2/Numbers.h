#pragma once
#include "Row.h"

class Numbers : public Row
{
public:
	Numbers(string Row);
	void Remove(char = '5') override;
};

