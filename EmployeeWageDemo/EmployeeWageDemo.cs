﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    public class EmployeeWageDemo
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmployeeWageDemo(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) 
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;      
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays) 
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
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
                Console.WriteLine("Days:#" + totalWorkingDays + " Emp Hrs" + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is " + totalEmpWage);
        }
        public override string ToString()
        {
            return "Total Emp Wage for company : " + company + " is " + totalEmpWage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageDemo dMart = new EmployeeWageDemo("DMart", 20, 2, 10);
            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.ToString());
            EmployeeWageDemo reliance = new EmployeeWageDemo("Reliance", 20, 2, 10);
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.ToString());
        }
    }
}
