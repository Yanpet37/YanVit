using System.Xml.Linq;

namespace Classes
{
    public abstract class EmployeeBase
    {
        public string Name { get; set; }

        public string Position { get; set; }
        public abstract string GetDetails();
    }

    class Manager : EmployeeBase
    {
        private string _grade; 
        public string Grade 
        {
            get => _grade; 
            set
            {
                if (value != "J" && value != "M" && value != "S")
                {
                    throw new ArgumentException("Grade must be J, M, or S.");
                }
                _grade = value; 
            }
        }
        public override string GetDetails()
        {
            return $"Manager Name: {Name}, Position: {Position}, Grade: {Grade}";
        }
        public class Project
        {
            public string ProjectName { get; set; }
            public DateTime Deadline { get; set; }

            public void DisplayProjectInfo()
            {
                Console.WriteLine($"Project Name: {ProjectName}, Deadline: {Deadline}");
            }
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
}

