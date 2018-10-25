using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Data_Structures
{
    class Stack<T> where T: IComparable
    {
        T[] elements;
        int topIndex;

        public Stack(int size)
        {
            elements = new T[size];
            topIndex = 0;
        }

        // Run time: O(1)
        public bool isEmpty()
        {
            return topIndex == 0;
        }

        // Run time: O(1)
        public T pop()
        {
            if (!isEmpty())
            {
                topIndex--;
                return elements[topIndex];
            }
            throw new Exception("underflow");
        }

        // Run time: O(1)
        public void push(T element)
        {
            if (topIndex >= elements.Length)
            {
                Array.Resize(ref elements, elements.Length * 2);
            }
            elements[topIndex] = element;
            topIndex++;
        }
    }
}
