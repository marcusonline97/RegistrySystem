using RegistrySystem.ProjectFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RegistrySystem.Math
{
    public static class MathHandler
    {
        private static int numberOfMonthsWorked;

        public static int TotalCost()
        {
            return 0;
        }

        public static void BigBanana()
        {
            var sampleString = "baceiouxyz";

            Console.WriteLine(sampleString + " => " + Utility.RemoveVowels(sampleString));
        }
        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numbersofMonthsWorked, int bonus) => monthlyWage * numbersofMonthsWorked + bonus;




        public static void UsingOptionalParameteres()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1, 100);
            Console.WriteLine($"Yearly wage for employee 1Bethany: {yearlyWageForEmployee1}");
        }
        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {
            Console.WriteLine($"The yearly Wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}
