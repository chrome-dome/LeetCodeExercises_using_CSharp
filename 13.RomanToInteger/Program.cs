//Given a roman numeral, convert it to an integer.

using System;
using System.Collections.Generic;

class RomanToInteger
{
    static Dictionary<char, int> RomanValues = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    static int RomanToInt(string s)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i > 0 && RomanValues[s[i]] > RomanValues[s[i - 1]])
            {
                result += RomanValues[s[i]] - 2 * RomanValues[s[i - 1]];
            }
            else
            {
                result += RomanValues[s[i]];
            }
        }
        return result;
    }

    static void Main()
    {
        string s = "XII";
        Console.WriteLine(RomanToInt(s));
        Console.ReadLine();
    }
}
