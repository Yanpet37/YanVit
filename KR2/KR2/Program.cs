using System;
using System.Text;

public static class IntExtensions
{
    public static string ToWords(this int number)
    {
        string[] digits = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        StringBuilder result = new StringBuilder();

        foreach (char digit in number.ToString())
        {
            result.Append(digits[digit - '0']).Append(" ");
        }

        return result.ToString().Trim();
    }
}

class Program
{
    static void Main()
    {
        int num = 1234;
        Console.WriteLine(num.ToWords()); 
    }
}
