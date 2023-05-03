using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeAttendance
    { 
        public static void Check()
        {
            int present = 1;
            Random rdm = new Random();
            int empCheck = rdm.Next(2);
            if (empCheck == present)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}
