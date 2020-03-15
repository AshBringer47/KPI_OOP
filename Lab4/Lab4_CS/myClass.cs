using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_CS
{
    class myClass
    {
        private char[] _myRow;
        public myClass() { }
        public myClass(string newString)
        {
            _myRow = newString.ToCharArray();
        }
        public myClass(myClass previousString)
        {
            _myRow = previousString.Value;
        }
        public char[] Value
        {
            get => _myRow;
            set => _myRow = value;
        }
        public int Length()
        {
            return _myRow.Length;
        }
        public static myClass operator +(myClass string1, myClass string2)
        {
            string temp = "";
            foreach (char symbol in string1.Value)
            {
                temp += symbol;
            }
            foreach (char symbol in string2.Value)
            {
                temp += symbol;
            }
            myClass result = new myClass
            {
                Value = temp.ToCharArray() /*(string1.Value.ToString() + string2.Value.ToString()).ToCharArray()*/
            };
            return result;
        }
        public static myClass operator -(myClass string1, char newSymbol)
        {
            string temp = "";
            foreach (char symbol in string1.Value)
            {
                if (symbol == newSymbol)
                    continue;
                temp += symbol;
            }
            myClass result = new myClass
            {
                Value = temp.ToCharArray()
            };
            return result;
        }
    }
}
