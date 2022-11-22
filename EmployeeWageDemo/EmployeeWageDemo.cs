using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    internal class EmployeeWageDemo
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;    
        public const int NUM_OF_WORKING_DAYS = 4;      
        public const int MAX_HRS_IN_MONTH = 16;        
        public static int ComputeEmpWage()      
        {
            int empHrs;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)   
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);   
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                if (totalEmpHrs > MAX_HRS_IN_MONTH)  
                {
                    totalEmpHrs = MAX_HRS_IN_MONTH;
                }
                Console.WriteLine("Day#:" + totalWorkingDays + "  " + "Working Hours : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;     
            Console.WriteLine("Total Emp Wage is : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}
