using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Challenge2
{
    internal class Employee
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }

        public int Salary { get; set; }
        public Employee()
        {
            FirstName = "Halil";
            Surname = "OZERDEM";
            Salary = 50000;

        }

        public Employee(string aFirstName, string aSurname, int aSalary)
        {
            this.FirstName = aFirstName;
            this.Surname = aSurname;
            this.Salary = aSalary;
        }

        public void Work()
        {
            Console.WriteLine("I'm working");
        }

        public new void Pause()
        {
            Console.WriteLine("I'm having a brake");
        }
    }
}
