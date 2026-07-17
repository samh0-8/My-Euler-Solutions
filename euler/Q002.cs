using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q002
    {
        public void QOO2_Solve()
        {
            int prior = 1;
            int current = 2;
            int hold = 0;
            int sum = 0;
            while (current < 4000000)
            {
                if (current % 2 == 0)
                {
                    sum = sum + current;
                }
                hold = current + prior;
                prior = current;
                current = hold;
            }
            Console.WriteLine(sum);

        }
    }
}

