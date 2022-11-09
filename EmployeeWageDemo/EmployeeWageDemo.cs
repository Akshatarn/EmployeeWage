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
            const int EMP_RATE_HR=20;
            int empPresent = 1;
            int empWage = 0;
            int empHrs = 0;
            Random r = new Random();
            int empInput = r.Next(0, 2);
            if (empPresent == empInput)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = EMP_RATE_HR * empHrs;
            Console.WriteLine("DAily Employee wage is:" + empWage);
            Console.ReadLine();

        }
    }
}
