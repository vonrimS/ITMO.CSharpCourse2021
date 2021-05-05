using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WhatDay2
{
    class WhatDay2
    {
        enum MonthName 
        { 
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            try
            {

                Console.Write("Please enter the day number, between 1 and 365: ");

                int dayNum = int.Parse(Console.ReadLine());
                if (dayNum < 1 || dayNum > 365)
                {
                    throw new System.ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

                foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                }

                MonthName temp = (MonthName)monthNum;

                string monthName = temp.ToString();

                Console.WriteLine("Ok, according to your input we have a result: \n\tday - {0} \n\tmonth - {1}", dayNum, monthName);

            }
            catch (System.Exception caught)
            {
                Console.WriteLine(caught);
            }          
        }
        static System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}

