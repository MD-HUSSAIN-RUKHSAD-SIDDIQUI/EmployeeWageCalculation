using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class DailyWage
    {
        public static void Calculate()
        {
            int ratePerHour= 20;
            int present = 1;
            int empHour = 0;
            int empWage = 0;
            Random rdm = new Random();
            int empCheck = rdm.Next(2);
            if (empCheck == present)
            {
                empHour = 8;
            }
            else
            {
                empHour = 0;

            }
            empWage = empHour * ratePerHour;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
