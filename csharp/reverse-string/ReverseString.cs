using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        return new string(charArray.Reverse().ToArray());
    }
}