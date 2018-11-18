using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var str = number.ToString();
        var result = 0;

        foreach (var num in str)
        {
            int test = Convert.ToInt16(num);
            result = test * str.Length;
            Console.WriteLine($"num: {test}, result: {str.Length}");
        }

        Console.WriteLine($"num: {number}, result: {result}");

        return result == number;
    }
}