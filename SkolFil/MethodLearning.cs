using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrySystem.SkolFil
{
    internal class MethodLearning
    {
        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            int local = 100;
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {
            int local = 150;
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;

        }

        public static double CalculateYearlyWage(double monthlyWage, doube)


    }
}
