//Given the root of a binary tree, return the inorder traversal of its nodes' values.

using System;
using System.Linq;
using System.Collections.Generic;

public class TreeNode
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

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        if (root == null) return result;
        result.AddRange(InorderTraversal(root.left));
        result.Add(root.val);
        result.AddRange(InorderTraversal(root.right));
        return result;
    }
    public static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
        Solution s = new Solution();
        var result = s.InorderTraversal(root);
        Console.WriteLine(string.Join(",", result));
        Console.ReadLine();
    }
}

