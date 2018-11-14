using System;
using System.Collections.Generic;
using System.Linq;
using static System.Linq.Enumerable;

public static class Raindrops
{
    private static Dictionary<int, string> _factors = new Dictionary<int, string>()
    {
        { 3, "Pling" },
        { 5, "Plang" },
        { 7, "Plong" }
    };

public static string Convert(int number)
    {
        return _factors.Aggregate("", (acc, factor) =>
        {
            if (number > 1 && number % factor.Key == 0)
            {
                acc = acc + factor.Value;
            }

            if (_factors.Keys.Last() == factor.Key && String.IsNullOrEmpty(acc))
            {
                acc = number.ToString();
            }
            return  acc;
        });
    }
}