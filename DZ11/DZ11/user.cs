using System;

public class User
{
    private string _name;
    private int _age;
    private string _email;

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Пустой ответ не принимается");
            _name = value;
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Возраст не может быть 0 или отрицательным числом");
            _age = value;
        }
    }
    public string Email
    {
        get { return _email; }
        set
        {
            if (!value.Contains("@"))
                throw new ArgumentException("Электронный адрес долже содержать @");
            _email = value;
        }
    }

    public User(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
    public override string ToString()
    {
        return $"Имя: {Name}, Возраст: {Age}, Email: {Email}";
    }
}