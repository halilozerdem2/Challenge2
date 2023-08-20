using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Trainee : Employee
    {
        public int workingHours { get; set; }
        public int schoolHours { get; set; }

        public Trainee(int aWorkingHours, int aSchoolHours, string aFirstName, string aSurname, int aSalary)
            : base(aFirstName, aSurname, aSalary)
        {
            this.schoolHours = aSchoolHours;
            this.workingHours = aWorkingHours;
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours!", schoolHours);
        }

        public void Work()
        {
            Console.WriteLine("I'm working for {0} hours!", workingHours);
        }

    }
}
