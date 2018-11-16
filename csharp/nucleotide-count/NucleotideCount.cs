using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    private static char[] _strands = new char[] { 'A', 'C', 'G', 'T' };

    public static IDictionary<char, int> Count(string sequence)
    {
        foreach (var s in sequence)
        {
            if (!_strands.Contains(s)) throw new ArgumentException();
        }
        return _strands.Aggregate(new Dictionary<char, int>(), FindStrands(sequence));
    }

    private static Func<Dictionary<char, int>, char, Dictionary<char, int>> FindStrands(string sequence)
    {
        return (acc, strand) =>
        {
            var result = sequence.Where(value => value == strand).Count();
            acc[strand] = result > 0 ? result : 0;
            return acc;
        };
    }
}