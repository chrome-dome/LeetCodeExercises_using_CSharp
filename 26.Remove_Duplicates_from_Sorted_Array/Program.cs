//Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.


int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0) return 0;
    int i = 0;
    for (int j = 1; j < nums.Length; j++)
    {
        if (nums[j] != nums[i])
        {
            i++;
            nums[i] = nums[j];
        }
    }
    return i + 1;
}

int[] nums = new int[] { 1, 1, 2 };
int newLength = RemoveDuplicates(nums);
Console.WriteLine(newLength); // output: 2
Console.WriteLine(string.Join(",", nums)); // output: 1,2
Console.ReadLine();
