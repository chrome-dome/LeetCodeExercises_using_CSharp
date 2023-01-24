//Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

using System;
using System.Linq;
using System.Collections.Generic;

class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

class Program
{
    static bool IsSymmetric(Node root)
    {
        if (root == null)
        {
            return true;
        }

        var leftQueue = new Queue<Node>();
        var rightQueue = new Queue<Node>();

        leftQueue.Enqueue(root.Left);
        rightQueue.Enqueue(root.Right);

        while (leftQueue.Any() && rightQueue.Any())
        {
            var left = leftQueue.Dequeue();
            var right = rightQueue.Dequeue();

            if (left == null && right == null)
            {
                continue;
            }

            if (left == null || right == null || left.Value != right.Value)
            {
                return false;
            }

            leftQueue.Enqueue(left.Left);
            leftQueue.Enqueue(left.Right);
            rightQueue.Enqueue(right.Right);
            rightQueue.Enqueue(right.Left);
        }

        return !leftQueue.Any() && !rightQueue.Any();
    }

    static void Main()
    {
        var root = new Node
        {
            Value = 1,
            Left = new Node
            {
                Value = 2,
                Left = new Node
                {
                    Value = 3
                },
                Right = new Node
                {
                    Value = 4
                }
            },
            Right = new Node
            {
                Value = 2,
                Left = new Node
                {
                    Value = 4
                },
                Right = new Node
                {
                    Value = 3
                }
            }
        };

        if (IsSymmetric(root))
        {
            Console.WriteLine("The tree is symmetric.");
        }
        else
        {
            Console.WriteLine("The tree is not symmetric.");
        }
        Console.ReadLine();
    }
}
