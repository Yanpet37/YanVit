using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student("Ян", 29, 7),
            new Student("Сергей", 30, 8),
            new Student("Марина", 25, 5),
        };
        students.Sort((s1, s2) => s2.Score.CompareTo(s1.Score));
        Console.WriteLine("Список студентов по среднему баллу:");
        foreach (var student in students)
        {
            student.Print();
        }
        students.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));
        Student youngest = students[0];
        Console.WriteLine("Самый младший студент:");
        youngest.Print();
    }
}