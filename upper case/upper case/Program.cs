using System;
using System.Globalization;
using System.Text.RegularExpressions;

class CapitalizeSentences
{
    public static string CapitalizeFirstLetterOfEachSentence(string text)
    {
        string result = Regex.Replace(text, @"(^\s*|[.!?]\s+)(\p{Ll})", match =>
        {
            return match.Groups[1].Value + match.Groups[2].Value.ToUpper(CultureInfo.InvariantCulture);
        });

        return result;
    }

    static void Main()
    {
        Console.Write("Введите текст: ");
        string input = Console.ReadLine();

        string result = CapitalizeFirstLetterOfEachSentence(input);
        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }
}