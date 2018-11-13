using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException();
        }

        return firstStrand.Where(CharactersAtIndexAreDifferent(secondStrand)).Count();
    }

    private static Func<char, int, bool> CharactersAtIndexAreDifferent(string strand)
    {
        return (char letter, int index) => strand.Length > index && letter != strand[index];
    }
}