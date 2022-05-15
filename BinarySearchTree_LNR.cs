﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //Creating binary search tree using generics and IComparable to use CompareTo method in program(UC1)
    public class BinarySearchTree_LNR<T> where T : IComparable<T>
    {
            //Initializing variables
            public int leftCount, rightCount;
            public bool result = false;

            //Declaring Properties
            public T NodeData { get; set; }
            public BinarySearchTree_LNR<T> LeftTree { get; set; }
            public BinarySearchTree_LNR<T> RightTree { get; set; }

            //Paramerterized constructor
            public BinarySearchTree_LNR(T nodeData)
            {
                this.NodeData = nodeData;
                this.LeftTree = null;
                this.RightTree = null;
            }


            //Method to check node and add node value to either left or right by comparing(UC1)
            public void Insert(T data)
            {
                T currentNodeValue = NodeData;
                if ((data.CompareTo(currentNodeValue)) < 0)
                {
                    if (this.LeftTree == null)
                        this.LeftTree = new BinarySearchTree_LNR<T>(data);
                    else
                        this.LeftTree.Insert(data);
                }
                else
                {
                    if (this.RightTree == null)
                        this.RightTree = new BinarySearchTree_LNR<T>(data);
                    else
                        this.RightTree.Insert(data);
                }
            }

            //Displaying the data in the binary tree(UC1)
            public void Display()
            {
                if (this.LeftTree != null)
                {
                    leftCount++;
                    LeftTree.Display();
                }
                Console.Write("Binary Tree:{0}", NodeData.ToString() + " " + "\n");
                if (this.RightTree != null)
                {
                    rightCount++;
                    RightTree.Display();
                }
            }
        //Method to get the size of the binary tree(UC2)
        /*Explanation of size of BST
          Start from the root.
          Size = 1 (for the root) + Size Of left Sub-Tree + Size Of right Sub-Tree.
          solve the left sub-tree and right sub-tree recursively.*/
        public void GetSize()
        {
            Console.WriteLine("Size of the binary tree is : " + (1 + this.leftCount + this.rightCount));
        }

    }
}