using System;
using System.Linq;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1) throw new ArgumentOutOfRangeException();

        Console.WriteLine($"number: {n}");

        int result = 0;

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine($"before: {n}, {result}");
            result += (i * 2) + result;
            Console.WriteLine($"after: {n}, {result}");

        }

        return result > 0 ? Convert.ToUInt64(result) : 1;
    }

    public static ulong Total()
    {
        return Square(64);
    }
}