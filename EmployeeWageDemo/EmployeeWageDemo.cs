using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    internal class EmployeeWageDemo
    {
       public const int EMP_RATE_HR = 20;
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int NUM_WRKNG_DAYS = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Computation");
            
            int empWage = 0;
            int empHrs = 0;
            int totalEmpWage = 0;
            for(int day = 0; day < NUM_WRKNG_DAYS; day++)
            {
                Random r = new Random();
                int empInput = r.Next(0, 3);
                switch (empInput)
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
                totalEmpWage += empWage;
                Console.WriteLine("Daily Employee wage is:" + empWage);
                Console.ReadLine();

            }
            Console.WriteLine("Monthly Employee wage is:" + totalEmpWage);

        }
    }
}
