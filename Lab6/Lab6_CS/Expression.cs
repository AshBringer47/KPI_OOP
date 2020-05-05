using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_CS
{
    class Expression
    {
        private readonly double _a, _c, _d;
        public Expression(double a, double c, double d) // constructor with parameters.
        {
            _a = a;
            _c = c;
            _d = d;
        }
        public double Calculate()
        {
            if (Math.Pow(_a, 2) == 1)
                throw new DivideByZeroException("You can't divide by zero. Denominator = 0"); // exception for divison by 0.
            if (_d == 0)
                throw new ArithmeticException("Incorrect logarithmitic argument"); // exception for taking log from 0.
            return (2 * _c - Math.Log(_d / 4, 10)) / (Math.Pow(_a, 2) - 1);
        }
    }
}
