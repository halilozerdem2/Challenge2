using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Boss: Employee
    {
        public string companyCar { get; set; }

        public Boss(string aCompanyCar, string aFirstName,string aSurname, int aSalary)
            : base(aFirstName,aSurname,aSalary) // it provides to use base classes contructor method
        {
            this.companyCar = aCompanyCar;

        }

        public void Lead()
        {
            Console.WriteLine("I'm the boss. My name is {0} {1} ",FirstName, Surname);
        }

    }
}
