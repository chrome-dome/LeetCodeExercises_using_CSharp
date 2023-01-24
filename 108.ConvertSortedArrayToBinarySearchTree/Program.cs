/*
Given an integer array nums where the elements are sorted in ascending order, convert it to a 
height-balanced binary search tree.
 */

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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 0) return null;
        int mid = nums.Length / 2;
        return new TreeNode(nums[mid],
            SortedArrayToBST(nums.Take(mid).ToArray()),
            SortedArrayToBST(nums.Skip(mid + 1).ToArray()));
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[] { -10, -3, 0, 5, 9 };
        TreeNode root = new Solution().SortedArrayToBST(nums);
        Console.WriteLine("Binary Search Tree: " + root.val);

        Console.ReadLine();
    }
}
