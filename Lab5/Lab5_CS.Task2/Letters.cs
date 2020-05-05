using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CS.Task2
{
    class Letters : Row
    {
        public Letters(string Row) : base(Row)
        {
            if (Row.Any(x => Char.IsDigit(x)))
                throw new Exception("Numbers in Letters constructor"); // checks, if there are numbers in string with letters.
        }
        public override int Length()
        {
            return base.Length();
        }
        public override void Remove(char ch = 'a') => _Row = new string(_Row.Where(c => !ch.ToString().Contains(c)).ToArray()); // removes char given in parameter list. If no parameter - removes 'a'.

    }
}
