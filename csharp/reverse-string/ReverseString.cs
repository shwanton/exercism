using System;
using System.Linq;
using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        return new string(charArray.Reverse().ToArray());
    }
}