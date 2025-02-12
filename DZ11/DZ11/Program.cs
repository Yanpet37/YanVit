using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<User> users = Management.LoadUsers(); 

        if (!File.Exists("users.json"))
        {
            Console.WriteLine("Файл users.json не найден, сейчас система его создаст");
        }

        if (users.Count == 0)
        {
            Console.WriteLine("Добавляем пользователей");
            users.Add(new User("Ян", 29, "yan@gmail.com"));
            users.Add(new User("Taras", 39, "taras@gmail.com"));
            users.Add(new User("Витя", 12, "vitya@gmail.com"));
            Management.SaveUsers(users);
        }

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить пользователя");
            Console.WriteLine("2. Показать всех пользователей");
            Console.WriteLine("3. Сохранить и выйти");

            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    UserActions.AddUser(users); 
                    break;
                case "2":
                    UserActions.ShowUsers(users); 
                    break;
                case "3":
                    Management.SaveUsers(users);
                    Console.WriteLine("Данные сохранены, выходим из программы");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте снова");
                    break;
            }
        }
    }
}
