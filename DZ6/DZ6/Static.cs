using System; 
using System.Collections.Generic;
using Classes;

namespace Static
{
    static class EmployeeRegistry
    {
        private static List<EmployeeBase> employees = new List<EmployeeBase>();
        public static void AddEmployee()
        { 
            while (true)
        {
            Console.WriteLine("Choose the type of employee to add:");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Worker");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string nameManager = Console.ReadLine();
                        Console.Write("Enter Position  (Delivery Manager/Project Manager: ");
                        string positionManager = Console.ReadLine();
                        Console.Write("Enter Grade (J, M, or S): ");
                        string grade;
                        while (true)
                        {
                            grade = Console.ReadLine();
                            if (grade == "J" || grade == "M" || grade == "S")
                            {
                                break;
                            }
                            Console.WriteLine("Grade must be J, M, or S. Please try again.");
                        }

                        Manager manager = new Manager
                        {
                            Name = nameManager,
                            Position = positionManager,
                            Grade = grade,
                        };

                        employees.Add(manager);
                        Console.WriteLine($"Manager {manager.Name} added.\n");
                        return;

                    case "2":
                        Console.Write("Enter Name: ");
                        string nameWorker = Console.ReadLine();
                        Console.Write("Enter Position (HR, BA, Dev): ");
                        string positionWorker = Console.ReadLine();
                        Console.Write("Enter Location (Minsk, London): ");
                        string location = Console.ReadLine();

                        Worker worker = new Worker
                        {
                            Name = nameWorker,
                            Position = positionWorker,
                            Location = location,
                        };

                        employees.Add(worker);
                        Console.WriteLine($"Worker {worker.Name} added.\n");
                        return;

                    default:
                        Console.WriteLine("\"Invalid choice. Please enter a valid number (1 or 2).\\n\"");
                        break;
                }
            }
        }


        public static void ListAllEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("The employee list is empty.\n");
                return;
            }

            Console.WriteLine("List of all employees:\n");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetDetails());
            }
        }
        public static void FindEmployee()
        {
            Console.WriteLine("Enter the name of the employee:");
            string name = Console.ReadLine();

            var matchingEmployees = employees.FindAll(e => e.Name == name);
            if (matchingEmployees.Count > 0)
            {
                Console.WriteLine($"Found {matchingEmployees.Count} employee(s):");
                foreach (var employee in matchingEmployees)
                {
                    Console.WriteLine(employee.GetDetails()); 
                }
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
