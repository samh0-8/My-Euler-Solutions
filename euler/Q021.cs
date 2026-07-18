using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q021
    {
        public void Q021_Solve()
        {
            List<int> amicable_numbers = new List<int>();
            int initial_sum_of_divisors = 0;
            int compared_sum_of_divisors = 0;
            bool add_in_x = true;
            bool add_in_inital_sum_of_divisors = true;

            for (int x = 1; x < 10000; x++)
            {
                for (int i = 1; i < x; i++) // finds sum of divisors in x.
                {
                    if (x % i == 0)
                    {
                        initial_sum_of_divisors = initial_sum_of_divisors + i;
                    }
                }
                for (int i = 1; i < initial_sum_of_divisors; i++) // finds sum of divisors in the number produced prior
                {
                    if (initial_sum_of_divisors % i == 0)
                    {
                        compared_sum_of_divisors = compared_sum_of_divisors + i;
                    }
                }
                if (compared_sum_of_divisors == x && x!=initial_sum_of_divisors) // checks if the number produced prior is the same as the inital number, x, being checked
                {
                    Console.WriteLine(1);
                    foreach (int i in amicable_numbers)
                    {
                        if (i == x)
                        {
                            add_in_x = false;
                        }
                        if (i == initial_sum_of_divisors)
                        {
                            add_in_inital_sum_of_divisors = false;
                        }
                    }
                    if (add_in_x == true)
                    {
                        amicable_numbers.Add(x);
                    }
                    if (add_in_inital_sum_of_divisors == true)
                    {
                        amicable_numbers.Add(initial_sum_of_divisors);
                    }
                }
                initial_sum_of_divisors = 0;
                compared_sum_of_divisors = 0;
                add_in_x = true;
                add_in_inital_sum_of_divisors = true;
            }



            int sum = 0;

            foreach (int i in amicable_numbers)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine(sum);


        } //fairly easy, but not sure about the 1s being produced?
    }
}
