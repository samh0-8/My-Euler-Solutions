using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] days = new char[] { 'm', 't', 'w', 'T', 'f', 's', 'S' }; //days of the week
            // Jan - 31, Feb - 28/29, March - 31, April - 30, May - 31, June - 30, July - 31, August - 31, September - 30, October-31, November - 30, December - 31
            // first sunday of each month
            // Jan 1 1901 = Tuesday
            string[] months = new string[] { "jan","feb","mar","apr","may","jun","jul","aug","sep","oct","nov","dec" };
            int p_days = 1; // pointer for days
            int p_months = -1; //pointer for months
            int year = 1901; //starting at 1901, and mod 4 is leap essentially
            int sun_count = 0;

            while (year<2001)
            {
                p_months = (p_months + 1) % 12; // 31 days
                if (months[p_months] == "jan" || months[p_months] == "mar" || months[p_months] == "may"  || months[p_months] == "jul" || months[p_months] == "aug"  || months[p_months] == "oct" || months[p_months] == "dec")
                {
                    p_days = (p_days + 31) % 7;
                    if (months[p_months] == "dec")
                    {
                        year++;
                    }

                }
                else if (months[p_months] == "apr" || months[p_months] == "jun"  || months[p_months] == "sep"  || months[p_months] == "nov") //30
                {
                    p_days = (p_days + 30) % 7;
                }
                else if (months[p_months] == "feb" )
                {
                    if (year % 4 == 0) //leap
                    {
                        p_days = (p_days + 29) % 7;
                    }
                    else //not a leap
                    {
                        p_days = (p_days + 28) % 7;
                    }
                }
                if (p_days == 6)
                {
                    sun_count++;
                    Console.WriteLine("The month " + months[(p_months + 1) % 12] + " in the year " + year + " had a Sunday on the first");
                }
            }
            Console.WriteLine(sun_count);
        }
    }
}
