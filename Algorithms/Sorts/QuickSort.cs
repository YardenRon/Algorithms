using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorts
{
    /*
     * Name: QuickSort
     * Description: Quick sort using the divide and conquer method. it partitiones the
     *              array A to 2 subarrays- A[i..j-1], A[j+1..k]
     *              such that each element in A[i..j-1] is <= to A[j] and
     *              each element in A[j+1..k] >= to A[j]. then, it repeats the process
     *              recursively for both subarrays.
     * Run time:
     * - worst case: O(n^2)
     * - avg case: O(nlogn)
     */
    class QuickSort
    {
        public static void execute(int[] array, int firstIndex, int lastIndex)
        {
            int pivotIndex = 0;
            if (firstIndex < lastIndex)
            {
                pivotIndex = partition(array, firstIndex, lastIndex);
                execute(array, firstIndex, pivotIndex - 1);
                execute(array, pivotIndex + 1, lastIndex);
            }
        }

        private static int partition(int[] subArray, int firstIndex, int lastIndex)
        {
            int pivot = subArray[lastIndex];
            int smallerIndex = firstIndex - 1;

            for (int biggerIndex = firstIndex; biggerIndex <= lastIndex-1; biggerIndex++)
            {
                if (subArray[biggerIndex] <= pivot)
                {
                    smallerIndex = smallerIndex + 1;
                    swap(subArray, smallerIndex, biggerIndex);
                }
            }

            swap(subArray, smallerIndex + 1, lastIndex);
            return smallerIndex + 1;
        }

        private static void swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
