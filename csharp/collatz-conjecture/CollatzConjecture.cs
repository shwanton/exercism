using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0) throw new ArgumentException();

        var steps = 0;

        Calculate(number, ref steps);

        return steps;
    }

    public static void Calculate(int number, ref int steps)
    {
        if (number == 1)
        {
            return;
        }

        steps++;

        if(number.IsEven())
        {
            Calculate(number / 2, ref steps);
        }
        else
        {
            Calculate(number * 3 + 1, ref steps);
        }
    }
}

public static class IntExtenstions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}
