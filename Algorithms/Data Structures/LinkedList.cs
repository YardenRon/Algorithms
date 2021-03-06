﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Data_Structures
{
    class Node<T> where T: IComparable
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }

    class LinkedList<T> where T : IComparable
    {
        public Node<T> Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        // Run time: O(1)
        public void insert(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = Head;
            if (Head != null)
            {
                Head.Prev = newNode;
            }

            Head = newNode;
        }

        // Run time: O(n)
        public void delete(T value)
        {
            Node<T> result = search(value);

            if (result != null)
            {
                if (result.Prev != null)
                {
                    result.Prev.Next = result.Next;
                }
                else
                {
                    Head = result.Next;
                }

                if (result.Next != null)
                {
                    result.Next.Prev = result.Prev;
                }
            }
        }

        // Run time: O(n)
        public Node<T> search(T value)
        {
            Node<T> current = Head;

            while(current != null)
            {
                if (current.Value.CompareTo(value) == 0)
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }
    }
}
