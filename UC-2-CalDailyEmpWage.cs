using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9_EmplyoeeWageProblem
{
      public class UC_2_CalDailyEmpWage
      {
        public const int isPresent = 0;
        public const int isAbsent = 1;
        private int wagePerHour = 20;
        private int fullDayHour = 8;
        private int DailyEmplyoeeWage = 0;

        
        public void DailWageCalculation()
        {
          
            Random random = new Random();
            int check2 = random.Next(2);

            if (check2 == isPresent)
            {
                fullDayHour = 8;
            }
            else
            {
                fullDayHour = 0;
            }
            DailyEmplyoeeWage = fullDayHour * wagePerHour;
            Console.WriteLine("Daily Emplyoee Wage is :-" + DailyEmplyoeeWage);

        }
      }
}
