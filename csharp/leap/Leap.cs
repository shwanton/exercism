using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        var every4Years = year % 4 == 0;
        var every100Years = year % 100 == 0;
        var every400Years = year % 400 == 0;

        if (!every4Years) return false;

        if (every100Years && !every400Years) return false;

        return true;
    }
}