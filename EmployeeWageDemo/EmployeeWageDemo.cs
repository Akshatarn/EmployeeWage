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
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empWage = 0;
            int empHrs = 0;
            Random r = new Random();
            int empInput = r.Next(0, 3);
            switch(empInput)
            {
                case FULL_TIME:
                    Console.WriteLine("Fulltime Employee is Present");
                    empHrs = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Parttime Employee is Present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    empHrs = 0;
                    break;


            }
            empWage = EMP_RATE_HR * empHrs;
            Console.WriteLine("DAily Employee wage is:" + empWage);
            Console.ReadLine();

        }
    }
}
