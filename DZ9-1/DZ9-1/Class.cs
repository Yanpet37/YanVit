public class Student
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 15)
                _age = value;
            else
                throw new ArgumentException("Возраст не может быть ниже 15!");
        }
    }

    private double _score;
    public double Score
    {
        get { return _score; }
        set
        {
            if (value >= 1 && value <= 10)
                _score = value;
            else
                throw new ArgumentException("Средний балл должен быть от 1 до 10!");
        }
    }

    public Student(string name, int age, double score)
    {
        Name = name;
        Age = age;
        Score = score;
    }

    public void Print()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Средний балл: {Score}");
    }
}

