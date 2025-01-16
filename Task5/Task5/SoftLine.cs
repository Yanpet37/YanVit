using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class SoftLine : Company
    {
        private string _name;
        private int _year;
        private string _region;
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
        public string Region
        {
            get
            {
                return _region;
            }
            set
            {
                _region = value;
            }
        }
        public SoftLine(string name, int year, string type)
        {
            _name = name;
            _year = year;
            _region = type;
        }
        public override void SeeInfo()
        {
            Console.WriteLine($"Компания: {Name}, Основана в: {Year}, Регион: {Region}");
        }
    }
}