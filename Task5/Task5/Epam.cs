using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Epam : Company
    {
        private string _name;
        private int _year;
        private string _type;
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
        public override int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public Epam(string name, int year, string type)
        {
            _name = name;
            _year = year;
            _type = type;
        }
        public override void SeeInfo()
        {
            Console.WriteLine($"Компания: {Name}, Основана в: {Year}, Тип компании: {Type}");
        }
    }
}
