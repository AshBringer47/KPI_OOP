using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_CS
{
    class FirstTask
    {
        public delegate int LineOperator(string str, char ch);
        public static int FirstChar(string str, char ch) => str.IndexOf(ch);
        public int firstChar(string str, char ch) => str.IndexOf(ch);
    }
}
