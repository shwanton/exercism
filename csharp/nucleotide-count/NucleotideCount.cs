using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    private static readonly IDictionary<char, int> Nucleotide = new Dictionary<char, int>()
    {
        ['A'] = 0,
        ['C'] = 0,
        ['G'] = 0,
        ['T'] = 0
    };

    public static IDictionary<char, int> Count(string sequence)
    {
        var result = new Dictionary<char, int>(Nucleotide);

        foreach (char c in sequence)
        {
            if (!Nucleotide.ContainsKey(c))
            {
                throw new ArgumentException("Invalid Nucleotide character");
            }

            result[c]++;
        }

        return result;
    }
}