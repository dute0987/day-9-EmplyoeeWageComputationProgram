using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9_EmplyoeeWageProblem
{
    public class UC_3_PartFullTime
    {
        public void CalPartFullTime()
        {
            int IsPartTime = 0;
            int IsFullTime = 1;
            int WageRatePerHour = 20;
            int EmpHour = 0;
            int EmpWage = 0;

            Random random = new Random();
            int num = random.Next(3);

            if (num == IsPartTime)
            {
                EmpHour = 8;
            }
            else if (num == IsFullTime)
            {
                EmpHour = 12;
            }
            else
            {
                EmpHour = 0;
            }

            EmpWage = EmpHour * WageRatePerHour;
            Console.WriteLine("The Emplyoee Wage is:- " + EmpWage);
        }
    }
}
