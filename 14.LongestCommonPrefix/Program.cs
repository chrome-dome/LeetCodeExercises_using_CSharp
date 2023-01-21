/*
-Write a function to find the longest common prefix string amongst an array of strings.
-If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 */

using System;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string[] strs = { "flower", "flow", "flight" };
        string lcp = solution.LongestCommonPrefix(strs);
        Console.WriteLine("Longest Common Prefix: " + lcp);
        Console.ReadLine();
    }


    public string LongestCommonPrefix(string[] strs)
    {

        string lcp = "";
        if (strs == null || strs.Length == 0)
        {
            return lcp;
        }

        string firstString = strs.ElementAt(0);
        int index = 0;
        foreach (var c in firstString.ToCharArray())
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (index >= strs.ElementAt(j).Length || c != strs.ElementAt(j).ElementAt(index))
                {
                    return lcp;
                }
            }
            lcp += c;
            index++;
        }

        return lcp;
    }
}

