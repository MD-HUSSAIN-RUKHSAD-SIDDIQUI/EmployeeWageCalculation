using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class PartTimeEmployee
    {
        public static void WageCalculation()
        {
            int empRate = 20;
            int fullTimeEmployee = 1;
            int partTimeEmployee= 2;
            int empHour = 0;
            int empWage = 0;
            Random rdm = new Random();
            int empCheck = rdm.Next(3);
            Console.WriteLine("random value : " + empCheck);
            if (empCheck == fullTimeEmployee)
            {
                Console.WriteLine("Employee is working FullTime");
                empHour = 8;
            }
            else if (empCheck == partTimeEmployee)
            {
                Console.WriteLine("Employee is working Part Time");
                empHour = 4;

            }
            else
            {
                Console.WriteLine("Employee is not present");
                empHour = 0;
            }
            empWage = empHour * empRate;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
