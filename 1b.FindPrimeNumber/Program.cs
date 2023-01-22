using System;
using System.Linq;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());
        if (IsPrime(input))
        {
            Console.WriteLine("TAK");
        }
        else
        {
            Console.WriteLine("NIE");
        }
    }
}