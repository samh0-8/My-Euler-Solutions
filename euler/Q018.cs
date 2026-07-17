using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q018
    {
        public void Q018_Solve()
        {
            int[][] triangle = new int[][]
            {
              new int [] { 75 },
              new int [] {95,64},
              new int [] {17,47,82 },
              new int [] {18,35,87,10 },
              new int[] { 20, 04, 82, 47, 65 },
              new int[]  {19,01,23,75,03,34 },
              new int[] { 88, 02, 77, 73, 07, 63, 67 },
              new int[] { 99, 65, 04, 28, 06, 16, 70, 92 },
              new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 },
              new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
              new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
              new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 },
              new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
              new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
              new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 }
            };
            int highest_max = 0;
            int max = 0;
            int current_line_max = 0;
            int current_rnd_line = 0;
            int current_rnd_line_max = 0;
            int position_of_previous_largest_1 = 0;
            int position_of_previous_largest_2 = 0;
            int k = 1;

            Random rnd = new Random();
            while (true)
            {
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < k; j++) // could make faster by j = positon of previous largest.
                    {
                        Console.WriteLine(i);
                        if (j == position_of_previous_largest_1 || j == position_of_previous_largest_1 + 1)
                        {
                            int multiplier = rnd.Next(1, 7);
                            current_rnd_line = (triangle[i][j]) * multiplier;
                            if (current_rnd_line >= current_rnd_line_max)
                            {
                                current_line_max = triangle[i][j];
                                position_of_previous_largest_2 = j;
                            }
                        }
                        max = max + current_line_max;
                        k++;
                        current_line_max = 0;
                        position_of_previous_largest_1 = position_of_previous_largest_2;
                    }
                    if (max  > highest_max) 
                    {  highest_max = max;
                        Console.WriteLine(highest_max);
                    }
                }
            }
            //1313 is the largest ignoring every other req.
        }
    }
}
