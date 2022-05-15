using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Welcome Message
            Console.WriteLine("-----Welcome To Binary Search Tree Program-----");

            //Creating binary search tree to insert and display node values(UC1)
            BinarySearchTree_LNR<int> binaryTree = new BinarySearchTree_LNR<int>(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(11);
            binaryTree.Insert(65);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(63);
            binaryTree.Insert(67);

            //Display inputs
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Created A Binary Search Tree");
            Console.WriteLine("--------------------------------");

            binaryTree.Display();
        }
    }
}
