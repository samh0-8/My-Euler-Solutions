using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q012
    {
        public void Q012_Solve()
        {
            int no_of_divisors = 0;
            int current_highest = 0;
            for (int i = 1; i < 20000; i++)
            {
                int triangular_number = (i * (i + 1)) / 2;
                for (int j = 1; j <= triangular_number; j++)
                {
                    if (triangular_number % j == 0)
                    {
                        no_of_divisors++;
                    }
                }
                if (no_of_divisors >= 500)
                {
                    Console.WriteLine(triangular_number + "IS THE ONE!");
                }
                if (current_highest < no_of_divisors)
                {
                    current_highest = no_of_divisors;
                }
                if (i % 100 == 0)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(current_highest);
                }
                no_of_divisors = 0;
            }
        }
    }
}
