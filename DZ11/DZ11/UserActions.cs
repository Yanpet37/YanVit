using System;
using System.Collections.Generic;

public static class UserActions
{
    public static void AddUser(List<User> users)
    {
        try
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Введите возраст: ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                    break;
                Console.WriteLine("Ошибка, введите положительное число.");
            }

            string email;
            while (true)
            {
                Console.Write("Введите email: ");
                email = Console.ReadLine();

                try
                {
                    User tempUser = new User(name, age, email); 
                    break; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Ошибка: {ex.Message}"); 
                }
            }

            User newUser = new User(name, age, email); 
            users.Add(newUser);

            Console.WriteLine("Пользователь добавлен");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    public static void ShowUsers(List<User> users)
    {
        if (users.Count == 0)
        {
            Console.WriteLine("Нет пользователей.");
            return;
        }

        Console.WriteLine("\nСписок пользователей:");
        users.ForEach(Console.WriteLine);
    }
}

