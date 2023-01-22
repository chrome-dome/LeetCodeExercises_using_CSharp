using System;
using System.Linq;

class Fibonacci
{
    static void Main()
    {
        int num = 10;
        IEnumerable<int> fibonacci = Enumerable.Range(0, num);
        fibonacci = fibonacci.Select(n => n < 2 ? n : fibonacci.ElementAt(n - 1) + fibonacci.ElementAt(n - 2));

        foreach (var number in fibonacci)
        {
            Console.WriteLine(number);
        }

        Console.ReadLine();
    }
}



