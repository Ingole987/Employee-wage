﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class ComputeEmpWageForMultipleCompanies
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int ComputeEmpWageX(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {

            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company: " + company + " is : " + totalEmpWage);
            return totalEmpWage;
        }

        internal static void ComputeEmpWage(string v1, object company, int v2, object empRatePerHour, int v3, object numOfWorkingDays, int v4, object maxHoursPerMonth)
        {
            throw new NotImplementedException();
        }

        //static void Main(String[] args)
        //{
        //    ComputeEmpWage("DMart",20,2,10);
        //    ComputeEmpWage("Reliance",10,4,20);
        //}

    }

}

