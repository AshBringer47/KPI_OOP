using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CS.Task2
{
    class Row
    {
        protected string _Row;
        public string Value => _Row;
        public Row(string Row)
        {
            _Row = Row;
        }
        public virtual int Length() => _Row.Length; // returns length of string.
        public virtual void Remove(char ch) => _Row = new string(_Row.Where(c => !ch.ToString().Contains(c)).ToArray()); // Creates a new string, if it meets char to remove, it skips it.
    }
}
