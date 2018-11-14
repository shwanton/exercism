using System;
using System.Collections.Generic;
using System.Linq;
using static System.Linq.Enumerable;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> results = new HashSet<int>();

        foreach (var multiple in multiples.Where(n => n > 0))
        {
            foreach (var num in Range(1, max - 1))
            {
                if (num > 0 && num % multiple == 0)
                {
                    results.Add(num);
                }
            }
        }

        return results.Count == 0 ? 0 : results.Aggregate((sum, value) => sum + value);
    }
}

