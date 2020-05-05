#pragma once
#include <string>
#include <iostream>
using namespace std;

class Row
{
protected:
    string _Row;
public:
    Row(string);
    string Value();
    virtual int Length();
    virtual void Remove(char);
};

