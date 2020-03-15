using System;

namespace Lab4_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass S1 = new myClass(); // via default constructor.
            myClass S2 = new myClass("Hello #Worl##d#"); // via parameter.
            myClass S3 = new myClass(S2); // via copying.
            Console.WriteLine(S1.Value);
            Console.WriteLine(S2.Value);
            Console.WriteLine(S3.Value);
            S2 -= '#';
            Console.WriteLine(S2.Value);
            S1 = S2 + S3;
            Console.WriteLine(S1.Value);

        }
    }
}
