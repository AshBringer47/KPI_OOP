using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CS.Task2
{
    class Numbers : Row
    {
        public Numbers(string Row) : base(Row)
        {
            if (Row.Any(x => Char.IsLetter(x)))
                throw new Exception("Letters in Numbers constructor"); // checks, if there are letters in string with numbers.
        }
        public override int Length()
        {
            return base.Length();
        }
        public override void Remove(char ch = '5') => _Row = new string(_Row.Where(c => !ch.ToString().Contains(c)).ToArray()); // removes char given in parameter list. If no parameter - removes '5'.
    }
}
