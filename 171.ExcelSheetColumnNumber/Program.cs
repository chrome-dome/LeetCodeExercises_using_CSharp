//Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.

using System;

class ExcelColumns
{
    public static int ColumnTitleToNumber(string columnTitle)
    {
        int columnNumber = 0;

        for (int i = 0; i < columnTitle.Length; i++)
        {
            columnNumber = columnNumber * 26 + (columnTitle[i] - 'A' + 1);
        }

        return columnNumber;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(ColumnTitleToNumber("A")); // prints 1
        Console.WriteLine(ColumnTitleToNumber("B")); // prints 2
        Console.WriteLine(ColumnTitleToNumber("Z")); // prints 26
        Console.WriteLine(ColumnTitleToNumber("AA")); // prints 27
        Console.WriteLine(ColumnTitleToNumber("AB")); // prints 28
        Console.ReadLine();
    }
}
