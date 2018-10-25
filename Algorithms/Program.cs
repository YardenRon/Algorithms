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

            #region QuickSort
            //int[] array = { 2, 8, 7, 1, 3, 5, 6, 4 };

            //Console.WriteLine("Array before sorting:");
            //printArray(array);

            //Sorts.QuickSort.execute(array, 0, array.Length-1);

            //Console.WriteLine("Array after quick sorting:");
            //printArray(array);
            //Console.ReadLine();
            #endregion

            #region LinkedList
            //Data_Structures.LinkedList<int> list = new Data_Structures.LinkedList<int>();
            //list.insert(1);
            //list.insert(2);
            //list.insert(5);
            //list.insert(4);

            //list.delete(2);
            //var node = list.search(1);
            #endregion

            #region BinarySearchTree
            //Data_Structures.BinarySearchTree<int> tree = new Data_Structures.BinarySearchTree<int>();
            //Data_Structures.TreeNode<int> node1 = new Data_Structures.TreeNode<int>(8);
            //Data_Structures.TreeNode<int> node2 = new Data_Structures.TreeNode<int>(9);
            //Data_Structures.TreeNode<int> node3 = new Data_Structures.TreeNode<int>(2);
            //Data_Structures.TreeNode<int> node4 = new Data_Structures.TreeNode<int>(5);
            //Data_Structures.TreeNode<int> node5 = new Data_Structures.TreeNode<int>(4);
            //Data_Structures.TreeNode<int> node6 = new Data_Structures.TreeNode<int>(3);
            //Data_Structures.TreeNode<int> node7 = new Data_Structures.TreeNode<int>(1);
            //tree.insert(node1);
            //tree.insert(node2);
            //tree.insert(node3);
            //tree.insert(node4);
            //tree.insert(node5);
            //tree.insert(node6);
            //tree.insert(node7);

            //tree.inorderTreeWalk(tree.Root);
            //Console.ReadLine();
            #endregion

            #region Stack
            Data_Structures.Stack<int> stack = new Data_Structures.Stack<int>(5);
            Console.WriteLine("Stack empty = " + stack.isEmpty());
            try
            {
                stack.pop();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            stack.push(6);
            Console.WriteLine("Stack empty = " + stack.isEmpty());

            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.ReadLine();
            #endregion
        }

        private static void printArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
