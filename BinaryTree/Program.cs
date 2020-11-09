using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Building a Tree
            var Tree = new BinarySearchTree<int>();

            //Insert a Value
            Tree.Insert(3);

            //Insert Values
            int[] Values = { 10, 5, 20, 6, 8, 15, 40, 1, 2, 9, 6 };
            Tree.Insert(Values);

            //Print Values (Sorted / InOrder)
            Console.WriteLine("InOrder");
            Tree.Traverse((Node<int> node) => Console.Write(node.Value + ", "), TraversalType.InOrder);
            Console.WriteLine();
            Console.WriteLine("OutOrder");
            //Print Values in reverse sorted Order
            Tree.Traverse((Node<int> node) => Console.Write(node.Value + ", "), TraversalType.OutOrder);
            Console.WriteLine();
            Console.WriteLine("PreOrder");
            //Print Values PreOrder
            Tree.Traverse((Node<int> node) => Console.Write(node.Value + ", "), TraversalType.PreOrder);
            Console.WriteLine();
            Console.WriteLine("PostOrder");
            //Print Values in Post Order
            Tree.Traverse((Node<int> node) => Console.Write(node.Value + ", "), TraversalType.PostOrder);
            Console.WriteLine();

            //You can do any operation you want in Tree.Traverse() but, be warned...
            //... you can change the values and this can mess up the Tree!

            //Find a Node with a Value
            var Node = Tree.Search(10);

            //Delete a Node
            Tree.DeleteNode(Node);
        }
    }
}
