using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Epam("EPAM Systems", 1993, "Аутсорсинг");
            company.SeeInfo();
        }
    }
}
