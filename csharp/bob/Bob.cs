using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        var says = statement.Trim();

        bool silent = String.IsNullOrEmpty(says);
        bool askingQuestion = Regex.IsMatch(says, @".*\?+$");
        bool yelling = says == says.ToUpper() && Regex.IsMatch(says, @"[A-Z]");
        bool yellingQuestion = yelling && askingQuestion;

        if (silent) return "Fine. Be that way!";
        if (yellingQuestion) return "Calm down, I know what I'm doing!";
        if (yelling) return "Whoa, chill out!";
        if (askingQuestion) return "Sure.";

        return "Whatever.";
    }
}