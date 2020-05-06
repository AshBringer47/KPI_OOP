#include "Log.h"

void Log::LogException(const char* exception, string fileName) {
    ofstream file; // creates an ofstream object.
    time_t my_time = time(NULL); // getting the date.
	file.open(fileName, ios_base::app); // creates/opens file.
	file << ctime(&my_time) << exception << endl; // outputs exception.
}
