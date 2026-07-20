using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q014
    {
        public void Q014_Solve()
        {
            long created = 0;
            int count = 1;
            int max_count = 0;
            bool con = true;
            for (int i = 100000; i < 1000000; i++)
            {
                created = i;
                while (con)
                {
                    if (created % 2 == 0)
                    {
                        created = created / 2;
                    }
                    else if (created % 2 == 1)
                    {
                        created = 3 * created + 1;
                    }
                    if (created == 1)
                    {
                        con = false;
                    }
                    count++;
                }
                if (count > max_count)
                {
                    max_count = count;
                    Console.WriteLine(i + " has a max count of " + max_count);
                }
                count = 1;
                con = true;
                if (i % 10000 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        } // once again, whenever issue prolly due to not large enough int being used.
    }
}
