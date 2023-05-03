using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class WageTillCondition
    {
        public static void Calculation()
        {
                
            int ratePerHr = 20;
            int fullTImeEmployee = 1;
            int partTimeEmployee= 2;
            int empHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHour = 0;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;
            Random rdm = new Random();

            while ((totalWorkingDays < 20)&& (totalWorkingHours < 100))
            {
                totalWorkingDays++;
                int empCheck = rdm.Next(3);
                Console.WriteLine("Random value is : " + empCheck);

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
                empWage = empHour * ratePerHr;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Employee rate per hour ="+ratePerHr);
            Console.WriteLine("Total Working Days="+ totalWorkingDays);
            Console.WriteLine("Total Working Hours="+ totalEmpHour);
            Console.WriteLine("Total Employee Wage=" + totalEmpWage);
        }
    }
}
