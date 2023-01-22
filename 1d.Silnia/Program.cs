using System;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        int n = 5;
        long factorial = Enumerable.Range(1, n).Aggregate((acc, x) => acc * x);
        Console.WriteLine(factorial); // 120
        Console.ReadLine();
    }
}