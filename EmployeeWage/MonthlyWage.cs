using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class MonthlyWage
    {
        public static void Calculation()
        {
            int perHourRate = 20;
            int fullTimeEmployee = 1;
            int partTimeEmployee = 2;
            int empHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHour = 0;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;
            Random rdm = new Random();

            while (totalWorkingDays < 20)
            {
                totalWorkingDays++;
                int empCheck = rdm.Next(3);
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
                totalEmpHour += empHour;
                empWage = empHour * perHourRate;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Per hour Rate=" + perHourRate);
            Console.WriteLine("Total Working Days=" + totalWorkingDays);
            Console.WriteLine("Total Working Hours=" + totalEmpHour);
            Console.WriteLine("Total Employee Wage =" + totalEmpWage);
        }
    }
}
