namespace DZ6_NEW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager Manager = new Manager("Yan", "PM", "Minsk");
            EmployeeRegistry.AddEmployee(Manager);  
            EmployeeRegistry.FindEmployee("Yan");
        }
    }
}
