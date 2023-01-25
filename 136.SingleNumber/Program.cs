/*
-Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
-You must implement a solution with a linear runtime complexity and use only constant extra space.
 */

int SingleNumber(int[] nums)
{
    int result = 0;
    foreach (int num in nums)
    {
        //the property of the XOR operator that a ^a = 0 and a ^0 = a
        result ^= num;
    }
    return result;
}

int[] nums = { 2, 2, 1 };
int single = SingleNumber(nums);
Console.WriteLine(single); // Output: 1
Console.ReadLine();
