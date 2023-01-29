//Write a function that reverses a string. The input string is given as an array of characters s.

//You must do this by modifying the input array in-place with O(1) extra memory.


//Version1 - 0(n)

void ReverseString(char[] s)
{
    int left = 0, right = s.Length - 1;
    while (left < right)
    {
        char temp = s[left];
        s[left++] = s[right];
        s[right--] = temp;
    }
}

char[] test = new char[] { 'h', 'e', 'l', 'l', 'o' };
ReverseString(test);
Console.WriteLine(new string(test)); //output: "olleh"

Console.ReadLine();


