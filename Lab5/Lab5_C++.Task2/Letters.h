#pragma once
#include "Row.h"
class Letters :	public Row
{
public:
	Letters(string);
	void Remove(char = 'a') override;
};

