using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q003
    {
        public void QO03_Solve()
        {
            long number_to_be_checked = 600851475143;
            bool prime = false;
            for (long x = 0; x < 10000; x++)
            {
                for (long y = 2; y < 10000; y++) //basically starting from 2 (inclusive), is x is divisible by this, they are not prime, if it gets to x = y, and it hasnt yet been divided then it must be prime.
                {
                    if (y < x)
                    {
                        if (x % y == 0)
                        {
                            break;
                        }
                    }
                    if (y == x && (x != 0) && (x != 1))
                    {
                        if (number_to_be_checked % x == 0)
                        {
                            Console.WriteLine(x);
                            Console.WriteLine("Current value of number to be checked is," + number_to_be_checked);
                            number_to_be_checked = number_to_be_checked / x;
                        }
                    }
                }
            }
            // quite a brute force and heurstic approach, better prime number gen later.
        }
    }
            
        
}
