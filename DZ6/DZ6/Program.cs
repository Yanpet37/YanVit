using System;
using Classes; 
using Static;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("= Welcome to the Employee Management System =\n");

                Console.WriteLine("Choose an action:\n");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. See list of all employees");
                Console.WriteLine("3. Find employee");
                Console.WriteLine("4. Leave the program\n");
                Console.WriteLine("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EmployeeRegistry.AddEmployee();
                        break;

                    case "2":
                        EmployeeRegistry.ListAllEmployees();
                        break;

                    case "3":
                        EmployeeRegistry.FindEmployee();
                        break;

                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice\n");
                        break;
                }

                while (true)
                {
                    Console.WriteLine("\nWhat would you like to do next?");
                    Console.WriteLine("1. Return to Main Menu");
                    Console.WriteLine("2. Exit the program");
                    Console.Write("Enter your choice: ");
                    string nextChoice = Console.ReadLine();

                    if (nextChoice == "1")
                    {
                        break;
                    }
                    else if (nextChoice == "2")

                    {
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
            }
        }
    }
}