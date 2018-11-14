using System;
using System.Linq;
using static System.Linq.Enumerable;

public static class Raindrops
{
    private static readonly (int factor, string label)[] _factors =
    {
        ( factor: 3, label: "Pling" ),
        ( factor: 5, label: "Plang" ),
        ( factor: 7, label: "Plong" )
    };

    public static string Convert(int number)
    {
        var result = _factors
            .Where(f => number % f.factor == 0)
            .Select(f => f.label)
            .DefaultIfEmpty(number.ToString());

        return String.Concat(result);
    }
}