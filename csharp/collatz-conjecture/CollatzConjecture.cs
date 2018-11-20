using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0) throw new ArgumentException();

        return Calculate(number);
    }

    public static int Calculate(int number, int steps = 0)
    {
        if (number == 1) return steps;

        return Calculate(number.IsEven() ? number / 2 : number * 3 + 1, steps += 1);
    }
}

public static class IntExtenstions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}
