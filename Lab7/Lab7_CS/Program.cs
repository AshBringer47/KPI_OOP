using System;

namespace Lab8_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gunawardana Shiron. IS92\n");
            LinkedList list = new LinkedList();
            list.Push(4);
            list.Push(5);
            list.Push(6);
            list.Print();
            list.MoreThanMeanRemove();
            list.Print();
        }
    }
}
