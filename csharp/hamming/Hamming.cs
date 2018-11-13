using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException();
        }

        var count = 0;
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (secondStrand[i] != firstStrand[i])
            {
                count++;
            }
        }

        return count;
    }
}