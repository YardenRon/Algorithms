using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 2, 8, 7, 1, 3, 5, 6, 4 };

            Console.WriteLine("Array before sorting:");
            printArray(array);

            Sorts.QuickSort.execute(array, 0, array.Length-1);

            Console.WriteLine("Array after quick sorting:");
            printArray(array);
            Console.ReadLine();
        }

        private static void printArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
