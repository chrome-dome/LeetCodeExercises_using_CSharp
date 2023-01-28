//Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.


void MoveZeroes(int[] nums)
{
    int nonZeroIndex = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            nums[nonZeroIndex++] = nums[i];
        }
    }
    for (int i = nonZeroIndex; i < nums.Length; i++)
    {
        nums[i] = 0;
    }
}

int[] nums = { 0, 1, 0, 3, 12 };
MoveZeroes(nums);
foreach (var n in nums)
Console.Write(n + " ");

Console.ReadLine();
