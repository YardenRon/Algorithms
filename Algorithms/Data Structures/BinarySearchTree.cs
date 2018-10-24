using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Data_Structures
{
    class TreeNode<T> where T: IComparable
    {
        public T Value { get; set; }
        public TreeNode<T> Parent { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Parent = null;
            Left = null;
            Right = null;
        }
    }

    class BinarySearchTree<T> where T: IComparable
    {
        public TreeNode<T> Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        // Run time: O(n)
        public void inorderTreeWalk(TreeNode<T> root)
        {
            if (root != null)
            {
                if (root.Left != null)
                {
                    inorderTreeWalk(root.Left);
                }

                Console.WriteLine(root.Value);

                if (root.Right != null)
                {
                    inorderTreeWalk(root.Right);
                }
            }
        }

        // Run time: O(n)
        public TreeNode<T> search(TreeNode<T> root, T value)
        {
            if (root != null)
            {
                if (root.Value.CompareTo(value) == 0)
                {
                    return root;
                }
                if (root.Value.CompareTo(value) > 0)
                {
                    search(root.Left, value);
                }
                else
                {
                    search(root.Right, value);
                }
            }
            return null;
        }

        // Run time: O(h) where h is the height of the tree
        public void insert(TreeNode<T> node)
        {
            TreeNode<T> parent = null;
            TreeNode<T> current = Root;

            while (current != null)
            {
                parent = current;
                if (node.Value.CompareTo(current.Value) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            node.Parent = parent;

            if (parent == null)
            {
                Root = node;
            }
            else
            {
                if (node.Value.CompareTo(parent.Value) < 0)
                {
                    parent.Left = node;
                }
                else
                {
                    parent.Right = node;
                }
            }
        }

        // Run time: O(n)
        public TreeNode<T> minimum(TreeNode<T> root)
        {
            TreeNode<T> current = root;
            while (current != null)
            {
                current = current.Left;
            }
            return current;
        }

        // Run time: O(h) where h is the height of the tree
        public TreeNode<T> successor(TreeNode<T> node)
        {
            if (node != null)
            {
                if (node.Right != null)
                {
                    return minimum(node.Right);
                }

                TreeNode<T> parent = node.Parent;

                while (parent != null && node == parent.Right)
                {
                    node = parent;
                    parent = parent.Parent;
                }
                return parent;
            }
            return null;
        }

        // Run time: O(h) where h is the height of the tree
        public void delete(TreeNode<T> node)
        {
            if (node != null)
            {
                // Case 1: no children
                if (node.Left == null && node.Right == null)
                {
                    if (node.Parent != null)
                    {
                        if (node.Parent.Left == node)
                        {
                            node.Parent.Left = null;
                        }
                        else
                        {
                            node.Parent.Right = null;
                        }
                    }
                    else
                    {
                        Root = null;
                    }
                }
                else
                {
                    // Case 3: 2 children
                    if (node.Left != null && node.Right != null)
                    {
                        // TODO: Complete
                    }
                    // Case 2: 1 child
                    else
                    {
                        TreeNode<T> child;
                        if (node.Left != null)
                        {
                            child = node.Left;
                            node.Left = null;
                        }
                        else
                        {
                            child = node.Right;
                            node.Right = null;
                        }
                        
                        if (node.Parent.Left == node)
                        {
                            node.Parent.Left = child;
                        }
                        else
                        {
                            node.Parent.Right = child;
                        }
                        node.Parent = null;
                    }
                }
            }
        }
    }
}
