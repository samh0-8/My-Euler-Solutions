using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q015
    {
        public void Q015_Solve()
        {
            // no idea how to actually do, so going to write alogrithm that goes a random path, and then checks whether that path has been traversed yet
            Random rnd = new Random();
            int routes_tried = 0;
            List<string> gone = new List<string>();
            string routes_potentially_added_str = "";
            int right_or_down = 0;

            int down_count = 0; // say down is 0.
            int right_count = 0; // say right is 1;

            bool to_be_added = true;


            while (routes_tried < 300000)
            {
                for (int x = 0; x < 13; x++)
                {
                    right_or_down = rnd.Next(0, 2);
                    if (right_or_down == 0 && down_count < 7)
                    {
                        routes_potentially_added_str += "0";
                        down_count++;
                    }
                    if (right_or_down == 0 && down_count >= 7)
                    {
                        routes_potentially_added_str += "1";
                        down_count++;
                    }
                    if (right_or_down == 1 && right_count < 7)
                    {
                        routes_potentially_added_str += "1";
                        right_count++;
                    }
                    if (right_or_down == 1 && right_count >= 7)
                    {
                        routes_potentially_added_str += "0";
                        right_count++;
                    }
                };
                foreach (string x in gone)
                {
                    if (x == routes_potentially_added_str)
                    {
                        to_be_added = false;
                        break;
                    }
                }
                if (to_be_added)
                {
                    gone.Add(routes_potentially_added_str);
                }
                down_count = 0;
                right_count = 0;
                routes_potentially_added_str = "";
                routes_tried++;
                to_be_added = true;

            }
            Console.WriteLine(gone.Count);
            foreach (string x in gone)
            {
                Console.WriteLine(x);
            }
        }
    }
}
