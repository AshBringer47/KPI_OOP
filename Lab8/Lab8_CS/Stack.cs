using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_CS
{
    class MyStack<T>
    {
        public delegate void StackHandler(StackHandlerArgs data);
        public event StackHandler Notify;
        private readonly int _size;
        private int _length;
        private T[] _array;
        public MyStack(int size)
        {                
            if (size < 0)                              
                throw new ArgumentOutOfRangeException("Exception caught. Negative value of stack size.");
            _size = size;                
            _length = 0;
            _array = new T[_size];
        }
        public int Size => _size;
        public int Length => _length;
        public T this[int index]
        {
            get => this._array[index];
        }
        public bool IsFull() => _size == _length;
        public bool IsEmpty() => _length == 0;
        public void Push(T data)
        {            
            if (IsFull())
            {
                Notify?.Invoke(new StackHandlerArgs("Can't add element. Stack overflow.", this));
            }
            else
            {
                _array[_length++] = data;
            }
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new NullReferenceException("Exception caught. Trying to get element from empty stack.");
            }
            else
            {
                return _array[_length - 1];
            }
        }
        public void Pop()
        {
            if(IsEmpty())
            {
                throw new NullReferenceException("Exception caught. Trying to remove element from empty stack.");
            }
            else
            {
                T[] temp = new T[--_length];
                for (int i = 0; i < _length; i++)
                    temp[i] = _array[i];
                _array = temp;          
            }
        }
        public void DisplayStack()
        {
            if (this.Length == 0)
                Console.WriteLine("Stack is empty");
            for (var i = 0; i < this.Length; i++)
                Console.Write(this[i] + (i != this.Length - 1 ? "->" : "\n"));
        }
    }
}
