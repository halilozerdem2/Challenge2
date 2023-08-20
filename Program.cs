using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee(" Michael", "MILLER", 40000);
            michael.Work();
            michael.Pause();

            Boss taylor = new Boss("Audi", "Taylor", "SWIFT", 100000);

            taylor.Lead();

            Trainee michelle = new Trainee(32, 8, "Michelle", "BLUE", 10000);
            michelle.Work();
            michelle.Learn();
            Console.ReadKey();

        }
    }
}
