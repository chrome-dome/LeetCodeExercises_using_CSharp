//Given two strings s and t, return true if t is an anagram of s, and false otherwise.

//An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

using System;

class Program
{
    static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var sChars = s.ToCharArray();
        Array.Sort(sChars);
        var tChars = t.ToCharArray();
        Array.Sort(tChars);

        for (int i = 0; i < sChars.Length; i++)
        {
            if (sChars[i] != tChars[i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        string s = "anagram";
        string t = "nagaram";

        Console.WriteLine(IsAnagram(s, t));
        Console.ReadLine();
    }
}

