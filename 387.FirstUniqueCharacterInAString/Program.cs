//Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

using System;

class MainClass
{
    public static int FirstNonRepeatingChar(string s)
    {
        int[] count = new int[256];
        int index = -1;

        // count the frequency of each character
        for (int i = 0; i < s.Length; i++)
        {
            count[s[i]]++;
        }

        // iterate through the string to find the first non-repeating character
        for (int i = 0; i < s.Length; i++)
        {
            if (count[s[i]] == 1)
            {
                index = i;
                break;
            }
        }

        return index;
    }

    public static void Main(string[] args)
    {
        string s = "leetcode";
        int index = FirstNonRepeatingChar(s);
        if (index == -1)
        {
            Console.WriteLine("There is no non-repeating character in the string.");
        }
        else
        {
            Console.WriteLine("The first non-repeating character is at index " + index);
        }
        Console.ReadLine();
    }
}
