using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var str = number.ToString();
        var result = str
            .Select(a => int.Parse(a.ToString()))
            .Select(b => Math.Pow(b, str.Length))
            .Sum();

        return Convert.ToInt32(result) == number;
    }
}