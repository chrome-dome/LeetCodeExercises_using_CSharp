/*
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:
-Starting with any positive integer, replace the number by the sum of the squares of its digits.
-Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
-Those numbers for which this process ends in 1 are happy.

Return true if n is a happy number, and false if not.
*/

using System;
using System.Collections.Generic;

public class HappyNumber
{
    public static void Main()
    {
        HappyNumber happy = new HappyNumber();
        Console.WriteLine(happy.IsHappy(19)); // Output: true
        Console.ReadLine();
    }

    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();
        while (n != 1)
        {
            int current = n;
            int sum = 0;

            // Sum the squares of the digits of the number
            while (current != 0)
            {
                int digit = current % 10;
                sum += digit * digit;
                current /= 10;
            }

            // If the number has been seen before, it's in a loop
            if (seen.Contains(sum))
            {
                return false;
            }
            seen.Add(sum);
            n = sum;
        }
        return true;
    }
}


