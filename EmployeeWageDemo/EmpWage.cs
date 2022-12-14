using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    internal class EmpWage
    {
        static void Main(string[] args)
        {
            EmployeeWageArrayBuilder empWageBuilder = new EmployeeWageArrayBuilder();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10); 
            empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.AddCompanyEmpWage("Tata", 30, 14, 40);
            empWageBuilder.ComputeEmpWage();
        }
    }
}
