using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class Management
{
    private static string filePath = "users.json"; 

    public static List<User> LoadUsers()
    {
        if (!File.Exists(filePath)) 
            return new List<User>(); 

        try
        {
            string json = File.ReadAllText(filePath); 
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при загрузке файла: {ex.Message}");
            return new List<User>(); 
        }
    }

    public static void SaveUsers(List<User> users)
    {
        try
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json); 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при сохранении файла: {ex.Message}");
        }
    }
}