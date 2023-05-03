using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class SwitchCase
    {
        public static void WageCalculation()
        {
            int empRate = 20;
            int fullTimeEmployee= 1;
            int partTimeEmployee = 2;
            int empHour = 0;
            int empWage = 0;
            Random rdm = new Random();
            int empCheck = rdm.Next(3);
            Console.WriteLine("random value : " + empCheck);
            
           
            switch (empCheck)
            {
                case 1:
                    empHour = 8;
                    break;
                case 2:
                    empHour = 4;
                    break;
                default:
                    empHour = 0;
                    break;
            }
            empWage = empHour * empRate;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
