
//Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

//You must not use any built-in exponent function or operator.

int squareRoot(int x)
{
    if (x == 0 || x == 1)
    {
        return x;
    }
    int i = 1;
    int result = 1;
    while (result <= x)
    {
        i++;
        result = i * i;
    }
    return i - 1;
}

Console.WriteLine(squareRoot(4)); // Output: 2
Console.WriteLine(squareRoot(9)); // Output: 3
Console.WriteLine(squareRoot(16)); // Output: 4

Console.ReadLine();
