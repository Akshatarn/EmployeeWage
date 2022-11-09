using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    internal class EmployeeWageDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Computation");
            int empPresent = 1;
            Random r = new Random();
            int empInput = r.Next(0, 10);
            if(empInput == empPresent)
            {
                Console.WriteLine("Employee is Present");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.ReadLine();
            }
        }
    }
}
