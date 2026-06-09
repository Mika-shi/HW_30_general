using System.Net.Mime;

namespace HW_30.Extensions;

public static class StringExtensions
{
    public static string ToUpper(this string text)
    {
        char[] chars = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            chars[i] = char.ToUpper(text[i]);
        }
        return new string(chars);
    }

    public static string ToLower(this string text)
    {
        char[] chars = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            chars[i] = char.ToLower(text[i]);
        }
        return new string(chars);
    }

    public static string Trim(this string text)
    {
        int start = 0;
        int end = text.Length - 1;
        while (start < text.Length && char.IsWhiteSpace(text[start]))
        {
            start++;
        }

        while (end >= start && char.IsWhiteSpace(text[end]))
        {
            end--;
        }

        if (start > end)
        {
            return string.Empty;
        }
        return text.Substring(start, end - start + 1);
    }

    public static bool IsNullOrEmptyWhiteSpace(this string? text)
    {
        if (text == null || text.Length == 0)
        {
            return true;
        }

        foreach (char symbol in text)
        {
            if (!char.IsWhiteSpace(symbol))
            {
                return false;
            }
        }
        return true;
    }
}