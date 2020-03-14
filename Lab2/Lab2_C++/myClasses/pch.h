#ifndef PCH_H
#define PCH_H
#include "framework.h"
#include <string>
#include <vector>
#include <cassert>
#include <iostream>

using namespace std;

namespace mySpace {
    class myString {
    public:
        myString(char*);
        char* Get();
        int stringLength();
    private:
        char* _newString;
        void Set(char*);
        friend class myText;
    };
    class myText
    {
    private:
        vector <myString> _newText;
        bool consonantCheck(char);
    public:
        void addString(myString);
        void removeString(int);
        void erase();
        int shortestRow();
        double consonantPercentage();
        void spaceClean(int);
        char* Get(int);
    };
}


#endif //PCH_H
