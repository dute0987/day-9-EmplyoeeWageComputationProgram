using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9_EmplyoeeWageProblem
{
    public class UC_4_SwitchCaseProblem
    {
        public void SwitchCase()
        {
            const int IsFulltime = 0;
            const int IsPartTime = 1;
            const int EmpRatePerHour = 20;
            int EmpHour = 0;
            int EmpWage = 0;

            Random random = new Random();
            int EmpCheck = random.Next(3);

            switch (EmpCheck)
            {
                case IsFulltime:
                    EmpHour = 12;
                    break;

                case IsPartTime:
                    EmpHour = 8;
                    break;

                default:
                    EmpHour = 0;
                    break;
            }
            EmpWage = EmpHour * EmpRatePerHour;
            Console.WriteLine("The Wage of Emplyoee is :- " + EmpWage);
        }
    }
}
