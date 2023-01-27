//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

using System;

class Program
{
    static bool ContainsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[] nums = new int[] { 1, 2, 3, 1 };
        bool result = ContainsDuplicate(nums);
        Console.WriteLine(result); // output: true

        Console.ReadLine();
    }
}
