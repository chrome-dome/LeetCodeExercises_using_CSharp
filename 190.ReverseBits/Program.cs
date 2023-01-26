//Reverse bits of a given 32 bits unsigned integer.

using System;

class ReverseBits
{
    static void Main(string[] args)
    {
        uint n = 43261596; //00000010100101000001111010011100
        uint reversed = ReverseBitsHelper(n);
        Console.WriteLine("Original: {0}", n);
        Console.WriteLine("Reversed: {0}", reversed);
        Console.ReadLine();
    }

    static uint ReverseBitsHelper(uint n)
    {
        uint reversed = 0;
        for (int i = 0; i < 32; i++)
        {
            reversed = (reversed << 1) | (n & 1);
            n >>= 1;
        }
        return reversed;
    }
}

