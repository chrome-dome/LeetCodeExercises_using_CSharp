//Given an array nums of size n, return the majority element.

//The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

int FindMajorityElement(int[] nums)
{
    int majorityElement = nums[0];
    int count = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == majorityElement)
        {
            count++;
        }
        else
        {
            count--;
            if (count == 0)
            {
                majorityElement = nums[i];
                count = 1;
            }
        }
    }
    return majorityElement;
}

int[] nums = { 3, 2, 3 };
int majorityElement = FindMajorityElement(nums);
Console.WriteLine("The majority element is: " + majorityElement);
Console.ReadLine();
