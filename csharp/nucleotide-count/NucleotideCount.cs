using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    private static readonly string strands = "ACGT";

    public static IDictionary<char, int> Count(string sequence)
    {
        if (!sequence.All(strands.Contains)) throw new ArgumentException();

        return (sequence + strands)
            .GroupBy(k => k)
            .ToDictionary(g => g.Key, g => g.Count() - 1);
    }
}