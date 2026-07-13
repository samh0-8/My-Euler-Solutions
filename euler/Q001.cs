using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    public class Q001
    {
        public void Q001_Solve()
        {
            int sum = 0;
            bool added_to_sum = false;
            for (int x = 0; x < 1000; x++)
            {
                added_to_sum = false;
                if (x % 3 == 0 && (added_to_sum == false))
                {
                    sum = sum + x;
                    added_to_sum = true;
                }
                if (x % 5 == 0 && (added_to_sum == false))
                {
                    sum = sum + x;
                    added_to_sum = true;
                }
                Console.WriteLine(x);
            }
            Console.WriteLine(sum);
        }
    }
}
