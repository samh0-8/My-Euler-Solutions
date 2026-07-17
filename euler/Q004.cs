using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q004
    {
        public void QOO4_Solve()
        {
            int product = 0;
            int current_largest_palindrome = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    product = i * j;
                    if (product > 100000) //basically testing it's a 6 digit number, could techincally do the different legths (ie 5 digit) and check if it's a palindrome for each length but not needed for this question.
                    {
                        string product_str = Convert.ToString(product);
                        if ((product_str[0] == product_str[5]) && (product_str[1] == product_str[4]) && (product_str[2] == product_str[3])) // testing if it's a palindrome
                        {
                            if (product > current_largest_palindrome)
                            {
                                current_largest_palindrome = product;
                                Console.WriteLine(current_largest_palindrome);
                            }
                        }
                    }
                }

            }
            Console.WriteLine(current_largest_palindrome);
        }
    }
    // Don't need a perfect solution to everything.
}
