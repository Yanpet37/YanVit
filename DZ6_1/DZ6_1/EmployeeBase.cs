namespace DZ6_1
{
    abstract class EmployeeBase
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public abstract string GetDetails();
    }

    class Manager : EmployeeBase
    {
        public string Grade { get; set; }

        public override string GetDetails()
        {
            return $"Manager Name: {Name}, Position: {Position}, Grade: {Grade}";
        }
    }
    class Worker : EmployeeBase
    {
        public string Location { get; set; }

        public override string GetDetails()
        {
            return $"Worker Name: {Name}, Position: {Position}, Location: {Location}";
        }
    }
    class Program //проверка
    {
        static void Main(string[] args) 
        {
            Manager manager = new Manager
            {
                Name = "Yan",
                Position = "Coordinator",
                Grade = "Senior"
            };

            Worker worker = new Worker
            {
                Name = "Sergei",
                Position = "Developer",
                Location = "Minsk"
            };

            Console.WriteLine(manager.GetDetails());
            Console.WriteLine(worker.GetDetails());
        }
    }
}

