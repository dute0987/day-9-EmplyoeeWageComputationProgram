using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9_EmplyoeeWageProblem
{
    public class UC_1_EmpPresentAbset
    {
        public void CheckPresentAbsent()
        {
            const int isPresent = 0;
            const int isAbsent = 1;

            Random random = new Random();
            int check1 = random.Next(2);

            if ( isPresent == check1 )

            {
                Console.WriteLine("Emplyoee is present");
            }

            else
            {
                Console.WriteLine("Emplyoee is absent");

            }
        }
    }
}
