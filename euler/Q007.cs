using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q007
    {
        public void QOO7_Solve()
        {
            long prime = 0; //no.ofprimes
            long THEprime = 0;

            for (long x = 0; x < 1000000; x++)
            {
                for (long y = 2; y < 1000000; y++) //basically starting from 2 (inclusive), is x is divisible by this, they are not prime, if it gets to x = y, and it hasnt yet been divided then it must be prime.
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
                        prime++;
                        Console.WriteLine(prime);
                        if (prime == 10001)
                        {
                            THEprime = x;
                            Console.WriteLine("This is THE PRIME" + THEprime);
                        }
                    }
                }
            }

        } // still not particularly optimised
    }
}
