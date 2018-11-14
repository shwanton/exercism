using System;
using System.Collections.Generic;
using System.Linq;
using static System.Linq.Enumerable;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return Enumerable
            .Range(0, max)
            .Where(IsMultiple(multiples))
            .Sum();
    }

    private static Func<int, bool> IsMultiple(IEnumerable<int> multiples)
    {
        return n => multiples.Where(m => m > 0).Any(m => n % m == 0);
    }
}

