using System; 
using System.Collections.Generic;
using DZ6_1; 

namespace DZ6_2_static
{
    static class EmployeeRegistry
    {
        private static List<EmployeeBase> employees = new List<EmployeeBase>();
        //сотрудников где-то нужно хранить, поэтому первым делом создаю такое место
        //List<EmployeeBase> — это список, который хранит сотрудников (EmployeeBase и его производные)
        //employees — название переменной

        public static void AddEmployee(EmployeeBase employee) 
        {
            employees.Add(employee);
            Console.WriteLine($"Employee {employee.Name} added.");
        }
    }
}
