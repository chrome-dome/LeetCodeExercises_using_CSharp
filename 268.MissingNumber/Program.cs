//Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

int FindMissingNumber(int[] nums)
{
    int n = nums.Length;
    int expectedSum = (n * (n + 1)) / 2;
    int actualSum = 0;
    for (int i = 0; i < n; i++)
    {
        actualSum += nums[i];
    }
    return expectedSum - actualSum;
}

int[] nums = { 3, 0, 1 };
int missingNum = FindMissingNumber(nums);
Console.WriteLine(missingNum); // Output: 2
Console.ReadLine();
