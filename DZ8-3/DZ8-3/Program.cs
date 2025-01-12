using System;
using System.Globalization;

namespace DZ8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while (true)
            {
                Console.WriteLine("Введите строку:");
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine("Некорректный ввод, введите строку.");
            }
            string allLower = input.ToLower();

            string allUpper = input.ToUpper();

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string titleCase = textInfo.ToTitleCase(input.ToLower());

            Console.WriteLine($"Все строчные: {allLower}");
            Console.WriteLine($"Все заглавные: {allUpper}");
            Console.WriteLine($"Первая буква каждого слова в заглавной: {titleCase}");
        }
    }
}
