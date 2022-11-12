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
        public const int MAX_HRS_IN_MONTH = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Computation");
            
            int empWage = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWrkngDays = 0;
            int totalEmpWage = 0;
            while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalWrkngDays < NUM_WRKNG_DAYS)
            {
                totalWrkngDays++;
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
                totalEmpHrs+=empHrs;
                //empWage = EMP_RATE_HR * empHrs;
                //totalEmpWage += empWage;
                Console.WriteLine("Days:" +totalWrkngDays + "Emp Hrs:" + empWage);
                Console.ReadLine();

            }
            totalEmpWage = totalEmpHrs * EMP_RATE_HR;
            Console.WriteLine("Total Employee wage is:" + totalEmpWage);

        }
    }
}
