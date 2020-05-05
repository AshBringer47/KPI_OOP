using System;
using static Lab6_CS.Log;

namespace Lab6_CS
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Log log = new Log(); // creates an object of Log to log the exceptions.
            Expression[] expressions = new Expression[4] // array of expressions(check the lab task).
            {
                new Expression(4, 2, 1), new Expression(3.3, 1.7, 0),
                new Expression(1, 3, 0), new Expression(4, 5, 6)
            };
            foreach (var expression in expressions)
            {
                try
                {
                    Console.WriteLine("Result = {0}", expression.Calculate()); // tries to calculate the expression's value.
                }
                catch(Exception e)
                {
                    log.LogException(e); // logs an exception into file.
                }
            }
        }
    }
}
