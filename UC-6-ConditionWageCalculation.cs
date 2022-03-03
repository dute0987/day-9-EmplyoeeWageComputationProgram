using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9_EmplyoeeWageProblem
{
    public class UC_6_ConditionWageCalculation
    {
        public void MaxConditionSatisfied()
        {
            int IsPartTime = 1;
            int IsFullTime = 2;
            int WageRatePerHour = 20;
            int NumberofWorkingDay = 20;
            int TotalSalary = 0;
            int EmpWage = 0;
            int EmpHour = 0;
            int MaxHourInMonth = 100;
            int TotalEmpHour = 0;
            int WorkingDay = 0;

            while (TotalEmpHour < MaxHourInMonth && WorkingDay < NumberofWorkingDay)
            {
                WorkingDay++;

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

                TotalEmpHour = (TotalEmpHour + EmpHour);
                Console.WriteLine("Total Emplyoee hour is:- " + TotalEmpHour);



            }
            TotalSalary = (TotalEmpHour * WageRatePerHour);
            Console.WriteLine("Total salary for 100 working hour is :- " + TotalSalary);
        }
    }
}
