using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_CS
{
    class MyClass
    {
        private bool[] myArray;
        private bool logicalSum;
        public MyClass(int size)
        {
            Array.Resize(ref myArray, size);
        }
        public bool LogicalSum
        {
            get
            {
                bool result = myArray[0];
                for (int i = 1; i < myArray.Length; i++)
                    result |= myArray[i];
                logicalSum = result;
                return logicalSum;
            }
        }
        public bool this[int index]
        {
            get
            {
                try
                {
                    return (Convert.ToBoolean(Convert.ToInt32(myArray[index]) ^ 1)) ;
                }
                catch(Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            set
            {
                try
                {
                    myArray[index] = value;
                }
                catch(Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

    }
}
