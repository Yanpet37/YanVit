namespace DZ6_NEW
{
    public static class EmployeeRegistry
    {
        static List<EmployeeBase> employees = new List<EmployeeBase>();
        public static void AddEmployee(EmployeeBase employee)//принимает объект типа EmployeeBase как параметр
        {
            employees.Add(employee);//Добавляет переданный объект в список listOfEmployees
        }
        public static void ListAllEmployees()
        {
            Console.WriteLine($"List of all employees");
            foreach (EmployeeBase employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Position: {employee.Position}");
            }
        }
        public static void FindEmployee(string name)
        {
            bool found = false; 

            foreach (EmployeeBase employee in employees)
            {
                if (employee.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase))//частичное совпадение, игнорирую размер букв
                {
                    Console.WriteLine($"Found: {employee.Name}, Position: {employee.Position}");
                    found = true; 
                }
            }
            if (!found)
            {
                Console.WriteLine("No employees found with the given name.");
            }
        }

    }
}
