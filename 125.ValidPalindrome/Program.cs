/*
-A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
-Given a string s, return true if it is a palindrome, or false otherwise.
 */

using System;
using System.Text.RegularExpressions;

static void Main(string[] args)
{
    Console.WriteLine(PalindromeChecker.IsPalindrome("A man, a plan, a canal: Panama"));
    Console.ReadLine();
}

public class PalindromeChecker
{
    public static bool IsPalindrome(string s)
    {
        // Convert string to lowercase
        s = s.ToLower();

        // Remove non-alphanumeric characters
        s = Regex.Replace(s, "[^a-z0-9]", "");

        // Check for palindrome
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
