using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gunawardana Shiron. IS92");
            bool result;
            int sum;
            Console.WriteLine(lessThan(-5, 35));
            Console.WriteLine(sumarize(-3, 15));
            lessThan(15, -10, out result);
            sumarize(-10, 15, out sum);
            Console.WriteLine(result);
            Console.WriteLine(sum);
        }
        private static int sumarize(int x, int y) // return via value.
        {
            int sum = x ^ y;
            int carry = x & y;
            while (Convert.ToBoolean(carry))
            {
                carry = carry << 1; // Move all bits on 1 on right.
                x = sum; 
                y = carry;
                sum = x ^ y; // Sum bits.
                carry = x & y;
            }
            return sum;
        }
        private static void sumarize(int x, int y, out int result)
        {

            int sum = x ^ y;
            int carry = x & y;
            while (Convert.ToBoolean(carry))
            {
                carry = carry << 1; // Move all bits on 1 on right.
                x = sum;
                y = carry;
                sum = x ^ y; // Sum bits.
                carry = x & y; // Invert all the bits.
            }
            result = sum;
        }
        private static bool lessThan(int num1, int num2) // return via value.
        {
            int l = Convert.ToString(Math.Abs(Math.Max(num1, num2)), 2).Length - 1; // Finds the longest number in term of bits.
            for (int j = l; j >= 0; j--)
            {
                if ((num1 & (num1 << j)) < (num2 & (num2 << j)))
                {
                    return true;
                }
            }
            return false;
        }
        private static void lessThan(int num1, int num2, out bool result) // return via reference.
        {
            int l = Convert.ToString(Math.Abs(Math.Max(num1, num2)), 2).Length - 1; // Finds the longest number in term of bits.
            for (int j = l; j >= 0; j--)
            {
                if ((num1 & (num1 << j)) < (num2 & (num2 << j))) // Compare current bits of each number.
                {
                   result = true;
                    return;
                }
            }
            result = false;
        }
    }
    
}