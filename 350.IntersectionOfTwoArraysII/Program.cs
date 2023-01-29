//Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

using System;
using System.Collections.Generic;

class MainClass
{
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> numCounts = new Dictionary<int, int>();
        List<int> intersections = new List<int>();

        // Count the occurrences of each number in nums1
        for (int i = 0; i < nums1.Length; i++)
        {
            if (numCounts.ContainsKey(nums1[i]))
            {
                numCounts[nums1[i]]++;
            }
            else
            {
                numCounts[nums1[i]] = 1;
            }
        }

        // Check for intersections
        for (int i = 0; i < nums2.Length; i++)
        {
            if (numCounts.ContainsKey(nums2[i]) && numCounts[nums2[i]] > 0)
            {
                intersections.Add(nums2[i]);
                numCounts[nums2[i]]--;
            }
        }

        return intersections.ToArray();
    }

    public static void Main(string[] args)
    {
        int[] nums1 = new int[] { 1, 2, 2, 1 };
        int[] nums2 = new int[] { 2, 2 };
        int[] intersection = Intersection(nums1, nums2);

        Console.WriteLine("Intersection of nums1 and nums2:");
        for (int i = 0; i < intersection.Length; i++)
        {
            Console.WriteLine(intersection[i]);
        }

        Console.ReadLine();
    }
}
