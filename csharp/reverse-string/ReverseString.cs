using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var result = "";
        for (int i = 0; i < input.Length; i++)
        {
            var index = i + 1;
            result += input[input.Length - index];
        }

        return result;
    }
}