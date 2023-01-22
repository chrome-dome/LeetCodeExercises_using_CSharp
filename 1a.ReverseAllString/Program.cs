using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input = "string to reverse";
        string output = new string(input.Reverse().ToArray());
        Console.WriteLine(output);
        Console.ReadLine();
    }
}
