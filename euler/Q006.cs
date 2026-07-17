using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q006
    {
        public void QOO6_Solve()
        {// sum of the squares first
            int square_sum = 0;
            int linear_sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                square_sum += i * i;
            }
            for (int i = 0; i <= 100; i++)
            {
                linear_sum += i;
            }
            linear_sum = linear_sum * linear_sum;
            Console.WriteLine(linear_sum - square_sum);
        }
    }
}
