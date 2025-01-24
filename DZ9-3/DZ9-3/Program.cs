using System.Text.RegularExpressions;

namespace DZ9_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputText))
            {
                Console.WriteLine("Вы ничего не ввели.");
                return;
            }
            string[] words = inputText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Regex.Replace(words[i], @"^\p{P}+|\p{P}+$", "").ToLower();
            }
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                    continue;

                if (wordCounts.TryGetValue(word, out int count))
                {
                    wordCounts[word] = count + 1; 
                }
                else
                {
                    wordCounts[word] = 1; 
                }
            }
            Console.WriteLine("\nУникальные слова и их количество:");
            foreach (var pair in wordCounts)
            {
                Console.WriteLine($"Слово: {pair.Key}, Количество: {pair.Value}");
            }
        }
    }
}
