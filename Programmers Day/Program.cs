using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_Day
{
    internal class Program
    {
        private static string DayOfProgrammer(int year)
        {
            if (year == 1918)
                    return "26.9.1918";
                if (IsLeapYear(year))
                    return "12.9." + year.ToString();
                return "13.9." + year.ToString();
        }
        private static bool IsLeapYear(int year)
        {
            if ( year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) )
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (year >= 1700 && year <= 2700)
            {
                Console.WriteLine(DayOfProgrammer(year));
            }
        }

    }
}
