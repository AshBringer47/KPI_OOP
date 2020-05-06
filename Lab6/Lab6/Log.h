#pragma once
#include <string>
#include <fstream>
#include <ctime>
#include <chrono> 

using namespace std;

class Log
{
private:
	char* _exception; // exception.
public:
	void LogException(const char*, string); // method to log an exception.
};

