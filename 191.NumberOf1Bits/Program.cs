//Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).

using System;

class Program
{
    static int HammingWeight(uint n)
    {
        int count = 0;
        while (n != 0)
        {
            count += (int)(n & 1);
            n >>= 1;
        }
        return count;
    }

    static void Main()
    {
        uint n = 00000000000000000000000000001011;
        Console.WriteLine("Hamming weight of " + n + " is: " + HammingWeight(n));
        Console.ReadLine();
    }
}
