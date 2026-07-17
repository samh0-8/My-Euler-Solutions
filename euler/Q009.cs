using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q009
    {
        public void QOO9_Solve()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            bool satisfied = false;
            while (satisfied == false)
            {
                for (int i = 0; i < 1000; i++)
                {
                    a = i;
                    if ((a * a) + (b * b) == (c * c))
                    {
                        if (a + b + c == 1000)
                        {
                            Console.WriteLine($"The wanted pythagorean triple: {a}^2 + {b}^2 = {c}^2");
                            satisfied = true; break;
                        }
                    }
                }
                b++;
                if (b == 1000)
                {
                    c++;
                    b = 0;
                }
                if (c == 1000)
                {
                    satisfied = true;
                }
            }
        
            }
        }
}
