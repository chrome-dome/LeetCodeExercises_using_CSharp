using System;
using System.Linq;

class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        throw new ArgumentException("No two sum solution");
    }
}

class Program
{
    static void Main()
    {
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        int[] result = new Solution().TwoSum(nums, target);
        Console.WriteLine("Indices of the two numbers that add up to the target: [{0}, {1}]", result[0], result[1]);
        Console.ReadLine();
    }
}