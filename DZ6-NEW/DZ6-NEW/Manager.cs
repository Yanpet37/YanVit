namespace DZ6_NEW
{
    internal class Manager : EmployeeBase
    {
        private string _name;
        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private string _position;
        public override string Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public Manager(string name, string position, string city)
        {
            Name = name;
            Position = position;
            City = city;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name {Name}, Position {Position}, City {City}");
        }
        public class Project
        {
            private string _projectName;
            public string ProjectName
            {
                get
                {
                    return _projectName;
                }
                set
                {
                    _projectName = value;
                }
            }
            private string _deadline;
            public string Deadline
            {
                get
                {
                    return _deadline;
                }
                set
                {
                    _deadline = value;
                }
            }
            public Project(string projectName, string deadline)
            {
                _projectName = projectName;
                _deadline = deadline;
            }
            public void DisplayProjectInfo()
            {
                Console.WriteLine($"Project name: {ProjectName} Project deadline: {Deadline}");
            }
        }
    }
}
