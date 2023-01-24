//Given an integer numRows, return the first numRows of Pascal's triangle.

using System;
using System.Collections.Generic;

public class PascalTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> triangle = new List<IList<int>>();

        if (numRows == 0)
        {
            return triangle;
        }

        triangle.Add(new List<int> { 1 });

        for (int i = 1; i < numRows; i++)
        {
            IList<int> row = new List<int>();
            row.Add(1);

            for (int j = 1; j < i; j++)
            {
                row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
            }

            row.Add(1);
            triangle.Add(row);
        }

        return triangle;
    }

    public static void Main(string[] args)
    {
        int numRows = 5;
        IList<IList<int>> triangle = PascalTriangle.Generate(numRows);

        foreach (IList<int> row in triangle)
        {
            foreach (int element in row)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }

}



