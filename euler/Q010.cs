using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q010
    {
        public void QO10_Solve()
        {
            // more efficient prime number generator
            List<int> prime_numbers = new List<int>();
            prime_numbers.Add(2);
            prime_numbers.Add(3);
            for (int i = 5; i < 100; i++)
            {
                for (int j = 0; j < prime_numbers.Count(); j++)
                {
                    if (i % prime_numbers[j] == 0)
                    {
                        break;
                    }

                }
            }
        } // FULL SOLUTION LOST, MIGHT NEED TO REDO
    }
}
