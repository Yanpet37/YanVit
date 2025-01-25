using System;

namespace DZ10
{
    class Program
    {
        static void Main(string[] args)
        {
            InputValidator validator = new InputValidator();

            Console.WriteLine("Введите слово 'боль':");
            string input = Console.ReadLine();

            try
            {
                validator.ValidateInput(input);
                Console.WriteLine("Введено правильно. Терпи друг");
            }
            catch (InvalidInputExceptionnn ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неожиданная ошибка, извините");
            }
        }
    }
}


