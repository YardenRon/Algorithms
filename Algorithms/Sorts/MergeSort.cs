using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorts
{
    /*
     * Name: MergeSort
     * Description: Merge sort using the divide and conquer method.
     *              1. it partitiones the array A to 2 subarrays- A[1..n/2], A[n/2+1..n]
     *              2. it execute merge sort recursively on both subarrays
     *              3. it merges the 2 sorted subarrays into one sorted array
     * Run time:
     * - worst case: O(nlogn)
     */
    class MergeSort
    {
        public static void merge(int[] array, int firstIndex, int divideIndex, int lastIndex)
        {
            int size1 = divideIndex - firstIndex+1;
            int size2 = lastIndex - divideIndex;

            int[] subArray1 = new int[size1 + 1];
            int[] subArray2 = new int[size2 + 1];

            int i, j;

            for (i = 0; i < size1; i++)
            {
                subArray1[i] = array[firstIndex + i];
            }

            for (j = 0; j < size2; j++)
            {
                subArray2[j] = array[divideIndex + j + 1];
            }

            subArray1[size1] = int.MaxValue;
            subArray2[size2] = int.MaxValue;

            i = 0;
            j = 0;
            for (int k = firstIndex; k <= lastIndex; k++)
            {
                if (subArray1[i] <= subArray2[j])
                {
                    array[k] = subArray1[i];
                    i++;
                }
                else
                {
                    array[k] = subArray2[j];
                    j++;
                }
            }
        }

        public static void mergeSort(int[] array, int firstIndex, int lastIndex)
        {
            if (firstIndex < lastIndex)
            {
                int halfIndex = (int) Math.Floor((double)(firstIndex + lastIndex) / 2);
                mergeSort(array, firstIndex, halfIndex);
                mergeSort(array, halfIndex + 1, lastIndex);
                merge(array, firstIndex, halfIndex, lastIndex);
            }
        }
    }
}
