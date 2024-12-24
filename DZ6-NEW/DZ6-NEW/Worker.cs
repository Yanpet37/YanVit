namespace DZ6_NEW
{
    internal class Worker : EmployeeBase
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

        private string _office;
        public string Office
        {
            get
            {
                return _office;
            }
            set
            {
                _office = value;
            }
        }
        public Worker(string name, string position, string office)
        {
            Name = name;
            Position = position;
            Office = office;
        }

        public override void GetDetails()
        {
           Console.WriteLine($"Name {Name}, Position {Position}, Office {Office}");    
        }
    }
}
