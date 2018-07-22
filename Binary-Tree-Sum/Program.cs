using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Sum
{
    class Program
    {
        class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        class BinaryTree
        {
            public Node Root;

            public int SumTree(Node root)
            {
                if (root == null)
                {
                    return 0;
                }
                else
                {
                    return SumTree(root.Left) + root.Data + SumTree(root.Right);
                }
            }
        }

        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.Root = new Node(26);
            bt.Root.Left = new Node(4);
            bt.Root.Right = new Node(10);
            bt.Root.Left.Left = new Node(19);
            bt.Root.Left.Right = new Node(1);

            int sum = bt.SumTree(bt.Root);
            Console.WriteLine("The sum of the tree is: " + sum);
            //The sum of the tree is: 60

        }
    }
}
