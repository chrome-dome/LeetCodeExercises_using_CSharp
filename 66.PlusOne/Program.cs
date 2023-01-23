﻿//You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

//Increment the large integer by one and return the resulting array of digits.


int[] PlusOne(int[] digits)
{
    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if (digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        digits[i] = 0;
    }
    int[] newDigits = new int[digits.Length + 1];
    newDigits[0] = 1;
    return newDigits;
}

int[] digits = new int[] { 1, 2, 3 };
int[] result = PlusOne(digits);
foreach (int digit in result)
{
    Console.Write(digit);
}

Console.ReadLine();