using System;
namespace day_9_EmplyoeeWageProblem
{
     class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Emplyoee Wage Program using OOPS for Day-9");

            //UC-1-emplyoeecheck
            //UC_1_EmpPresentAbset UC1 = new UC_1_EmpPresentAbset();
            //UC1.CheckPresentAbsent();

            //UC-2-Daily Emplyoee Wage Calculation
            //UC_2_CalDailyEmpWage UC2 = new UC_2_CalDailyEmpWage();
            //UC2.DailWageCalculation();

            //UC-3-Problem
            //UC_3_PartFullTime UC3 = new UC_3_PartFullTime();
            //UC3.CalPartFullTime();

            //UC-4-Solved Using Case Statment
            //UC_4_SwitchCaseProblem UC4 = new UC_4_SwitchCaseProblem();
            //UC4.SwitchCase();

            //UC-5-Switch Case Solved
            //UC_5_WageForMonth UC5 = new UC_5_WageForMonth();
            //UC5.MonthWage();

            //UC-6-Wage By Condition Satisfied
            //UC_6_ConditionWageCalculation UC6 = new UC_6_ConditionWageCalculation();
            //UC6.MaxConditionSatisfied();


            //UC_8_MultipleCompanyWage DMart = new UC_8_MultipleCompanyWage("DMart", 20, 2, 10);
              UC_8_MultipleCompanyWage Reliance = new UC_8_MultipleCompanyWage("Reliance", 16, 4, 15);

              DMart.ComputeEmpWage();
              Console.WriteLine(DMart.ToString());

              Reliance.ComputeEmpWage();
              Console.WriteLine(Reliance.ToString());



        }
     
     } 
}
