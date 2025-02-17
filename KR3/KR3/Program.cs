using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 8, 3, 12, 7, 9, 2, 6, 10 };
        Console.WriteLine("Исходный список после самостоятельной инициализации: " + string.Join(", ", numbers));

        numbers = numbers.OrderBy(x => x).ToList();
        Console.WriteLine("После сортировки по возрастанию: " + string.Join(", ", numbers));

        int firstHalfCount = (numbers.Count + 1) / 2;
        Console.WriteLine("Индекс второй половины (округлено вверх): " + firstHalfCount);

        List<int> secondHalf = numbers.Skip(firstHalfCount).ToList();
        Console.WriteLine("Вторая половина: " + string.Join(", ", secondHalf));

        secondHalf = secondHalf.OrderByDescending(x => x).ToList();
        Console.WriteLine("Сортирую по убыванию: " + string.Join(", ", secondHalf));

        List<int> result = secondHalf.Select(x => x * x).ToList();
        Console.WriteLine("Возвёл в квадрат: " + string.Join(", ", result));
    }
}


