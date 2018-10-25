using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Data_Structures
{
    class Queue<T>
    {
        T[] elements;
        int headIndex;
        int tailIndex;
        bool isFull;

        public Queue(int size)
        {
            elements = new T[size];
            headIndex = 0;
            tailIndex = 0;
            isFull = false;
        }

        // Run time: O(1)
        public bool isEmpty()
        {
            return headIndex == tailIndex && !isFull;
        }

        // Run time: O(1)
        public void enqueue(T element)
        {
            if (isFull)
            {
                throw new Exception("Queue is full");
            }
            elements[tailIndex] = element;
            tailIndex = (tailIndex + 1) % elements.Length;

            if (headIndex == tailIndex)
            {
                isFull = true;
            }
        }

        // Run time: O(1)
        public T dequeue()
        {
            if (isEmpty())
            {
                throw new Exception("Queue is empty");
            }
            T element = elements[headIndex];

            if (isFull)
            {
                isFull = false;
            }
            headIndex = (headIndex + 1) % elements.Length;
            return element;
        }
    }
}
