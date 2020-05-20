using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_CS
{
    class LinkedList
    {
        private class Node
        {
            public int _data;
            public Node _next;
            public Node(short data, Node _next = null)
            {
                this._data = data;
                this._next = _next;
            }
        }
        private Node _head;
        public int Size { get; private set; }
        public LinkedList()
        {
            _head = null;
            Size = 0;
        }
        public void Push(short data) 
        {
            _head = new Node(data, _head);
            Size++;
        }
        public int ThreeDivided()
        {
            int counter = 0;
            Node current = this._head;
            while(current != null)
            {
                counter = (current._data % 3 == 0) ? ++counter : counter;
                current = current._next;
            }
            return counter;
        }
        public double Mean()
        {
            double sum = 0;
            Node current = this._head;
            while(current != null)
            {
                sum += current._data;
                current = current._next;
            }
            return sum / this.Size;
        }
        public void MoreThanMeanRemove()
        {
            double Mean = this.Mean();
            Node current = this._head;
            int counter = 0;
            while(current != null)
            {
                if(current._data > Mean)
                {
                    current = current._next;
                    RemoveAt(counter);
                    continue;
                }
                counter++;
                current = current._next;
            }
        }
        public void RemoveAt(int index)
        {
            if (index == 0)
                PopFront();
            else
            {
                Node previous = this._head;
                for (var i = 0; i < index - 1; i++)
                    previous = previous._next;
                previous = previous._next._next;
                Size--;
            }
                
        }
        public void PopFront()
        {
            _head = _head._next;
            --Size;
        }
        public void Print()
        {
            int counter = 0;
            Node current = this._head;
            Console.WriteLine("Your list: ");
            while(current != null) 
            {
                Console.Write(current._data + ((counter != this.Size - 1) ? " -> " : "\n"));
                current = current._next;
                counter++;
            }                
        }
    }
}
