using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CS.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gunawardana Shiron. IS-92\nEnter your row: ");
            Row row = new Row(Console.ReadLine()); // creates an object of type Row.
            Console.Write("\nBase row: {0}\nIts length = {1}{2}", row.Value, row.Length(), "\nEnter char to remove: ");
            row.Remove(Console.ReadKey().KeyChar); // removes any custom char.
            Console.WriteLine("\nAfter removing a symbol: {0}\nIts length = {1}", row.Value, row.Length());
            Console.Write("\nEnter your numbers row: ");
            Numbers numbers = new Numbers(Console.ReadLine()); // creates an object of type Numbers.
            Console.WriteLine("\nNumbers row: {0}\nIts length = {1}", numbers.Value, numbers.Length());
            numbers.Remove(); // removes char '5'.
            Console.Write("\nAfter removing symbol '5': {0}\nIts length = {1}{2}", numbers.Value, numbers.Length(), "\nEnter char to remove: ");
            numbers.Remove(Console.ReadKey().KeyChar); // now removes custom number char.
            Console.WriteLine("\nAfter removing symbol: {0}\nIts length = {1}", numbers.Value, numbers.Length());
            Console.Write("\nEnter your letters row: ");
            Letters letters = new Letters(Console.ReadLine()); // creates an object of type Letters.
            Console.WriteLine("\nLetters row: {0}\nIts length = {1}", letters.Value, letters.Length());
            letters.Remove(); // removes char 'a'.
            Console.Write("\nAfter removing symbol 'a': {0}\nIts length = {1}{2}", letters.Value, letters.Length(), "\nEnter char to remove: ");
            letters.Remove(Console.ReadKey().KeyChar); // now removes custom char.
            Console.WriteLine("\nAfter removing symbol: {0}\nIts length = {1}", letters.Value, letters.Length());
        }
    }
}
