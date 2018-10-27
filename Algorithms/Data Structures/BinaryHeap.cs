using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Data_Structures
{
    class BinaryHeap<T> where T: IComparable
    {
        T[] elements;

        public int size { get; set; }

        public BinaryHeap(int arraySize)
        {
            elements = new T[arraySize];
            size = 0;
        }

        public int parent(int index)
        {
            return (int) Math.Floor((double) index / 2);
        }

        public int left(int index)
        {
            return 2 * index;
        }

        public int right(int index)
        {
            return 2 * index + 1;
        }

        // Run time: O(logn)
        public void maxHeapify(int nodeIndex)
        {
            int leftIndex = left(nodeIndex);
            int rightIndex = right(nodeIndex);

            bool rightLargerThanParent = 
                elements[rightIndex].CompareTo(elements[nodeIndex]) > 0;

            int largest =
                (rightIndex <= size && rightLargerThanParent) ? rightIndex : nodeIndex;

            bool leftLargerThanLargest =
                elements[leftIndex].CompareTo(elements[largest]) > 0;

            if (leftIndex <= size && leftLargerThanLargest)
            {
                largest = leftIndex;
            }

            if (largest != nodeIndex)
            {
                exchange(nodeIndex, largest);
                maxHeapify(largest);
            }

        }

        public void exchange(int index1, int index2)
        {
            T temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;
        }

        // Run time: O(n)
        public void buildMaxHeap()
        {
            size = elements.Length;
            int halfIndex = (int)Math.Floor((double)size / 2);

            for (int index = halfIndex; index >= 1; index--)
            {
                maxHeapify(index);
            }
        }

        // Run time: O(nlogn)
        public void heapSort()
        {
            buildMaxHeap();

            for (int index = elements.Length-1; index >= 2; index--)
            {
                exchange(0, index);
                size--;
                maxHeapify(0);
            }
        }
    }
}
