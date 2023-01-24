
/*
-Given the root of a binary tree, return its maximum depth.
-A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
*/


using System;
using System.Linq;

class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

class Program
{
    static int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }

    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        Console.WriteLine(MaxDepth(root)); // Output: 3
        Console.ReadLine();
    }
}
