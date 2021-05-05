using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WhatDay3
{
    class WhatDay3
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
                Console.Write("Please write year number, in the Gregorian calendar:");

                int yearNum = int.Parse(Console.ReadLine());

                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);

                int maxDayNum = isLeapYear ? 366 : 365;

                if (isLeapYear) 
                {
                    Console.WriteLine("IS a Leap year");
                }
                else
                {
                    Console.WriteLine("is NOT a Leap year");
                }

                Console.Write("Please enter the day number, between 1 and {0}:", maxDayNum);

                int dayNum = int.Parse(Console.ReadLine());

                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new System.ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

                if(isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
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

                }else
                {
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
        static System.Collections.ICollection DaysInLeapMonths = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}

