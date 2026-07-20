using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    internal class Q017
    {
        public void Q017_Solve()
        {
            int[] character_length_ones = [0, 3, 3, 5, 4, 4, 3, 5, 5, 4,]; //0-9
            int[] character_length_tens_special = [3, 6, 6, 8, 8, 7, 7, 9, 8, 8]; //10-19
            int[] character_length_tens = [0, 6, 6, 5, 5, 5, 7, 6, 6]; //0intens and 20-90
            int[] character_length_hundreds = [0, 13, 13, 15, 14, 14, 13, 15, 15, 14]; //0inhundreds and 100-900 including ands
            int count = 11 - 27; // add a thousand, removes 9 'ands' as well, for example its three hundred NOT three hundred and.
            int current_count = 0;

            for (int i = 1; i < 1000; i++)
            {
                {
                    string stringx = Convert.ToString(i);
                    while (stringx.Length != 3)
                    {
                        stringx = "0" + stringx;
                    }
                    switch (stringx[0]) //checks hundreds
                    {
                        case '0':
                            count = count + character_length_hundreds[0];
                            current_count = current_count + character_length_hundreds[0];
                            break;
                        case '1':
                            count = count + character_length_hundreds[1];
                            current_count = current_count + character_length_hundreds[1];
                            break;
                        case '2':
                            count = count + character_length_hundreds[2];
                            current_count = current_count + character_length_hundreds[2];
                            break;
                        case '3':
                            count = count + character_length_hundreds[3];
                            current_count = current_count + character_length_hundreds[3];
                            break;
                        case '4':
                            count = count + character_length_hundreds[4];
                            current_count = current_count + character_length_hundreds[4];
                            break;
                        case '5':
                            count = count + character_length_hundreds[5];
                            current_count = current_count + character_length_hundreds[5];
                            break;
                        case '6':
                            count = count + character_length_hundreds[6];
                            current_count = current_count + character_length_hundreds[6];
                            break;
                        case '7':
                            count = count + character_length_hundreds[7];
                            current_count = current_count + character_length_hundreds[7];
                            break;
                        case '8':
                            count = count + character_length_hundreds[8];
                            current_count = current_count + character_length_hundreds[8];
                            break;
                        case '9':
                            count = count + character_length_hundreds[9];
                            current_count = current_count + character_length_hundreds[9];
                            break;
                    }
                    if (stringx[1] == '1') // does this if tens digits begins with a one, special
                    {
                        switch (stringx[2])
                        {
                            case '0':
                                count = count + character_length_tens_special[0];
                                current_count = current_count + character_length_tens_special[0];
                                break;
                            case '1':
                                count = count + character_length_tens_special[1];
                                current_count = current_count + character_length_tens_special[1];
                                break;
                            case '2':
                                count = count + character_length_tens_special[2];
                                current_count = current_count + character_length_tens_special[2];
                                break;
                            case '3':
                                count = count + character_length_tens_special[3];
                                current_count = current_count + character_length_tens_special[3];
                                break;
                            case '4':
                                count = count + character_length_tens_special[4];
                                current_count = current_count + character_length_tens_special[4];
                                break;
                            case '5':
                                count = count + character_length_tens_special[5];
                                current_count = current_count + character_length_tens_special[5];
                                break;
                            case '6':
                                count = count + character_length_tens_special[6];
                                current_count = current_count + character_length_tens_special[6];
                                break;
                            case '7':
                                count = count + character_length_tens_special[7];
                                current_count = current_count + character_length_tens_special[7];
                                break;
                            case '8':
                                count = count + character_length_tens_special[8];
                                current_count = current_count + character_length_tens_special[8];
                                break;
                            case '9':
                                count = count + character_length_tens_special[9];
                                current_count = current_count + character_length_tens_special[9];
                                break;
                        }
                    }
                    else if (stringx[1] != '1')
                    {
                        switch (stringx[1]) //tens digit
                        {
                            case '0':
                                count = count + character_length_tens[0];
                                current_count = current_count + character_length_tens[0];
                                break;
                            case '2':
                                count = count + character_length_tens[1];
                                current_count = current_count + character_length_tens[1];
                                break;
                            case '3':
                                count = count + character_length_tens[2];
                                current_count = current_count + character_length_tens[2];
                                break;
                            case '4':
                                count = count + character_length_tens[3];
                                current_count = current_count + character_length_tens[3];
                                break;
                            case '5':
                                count = count + character_length_tens[4];
                                current_count = current_count + character_length_tens[4];
                                break;
                            case '6':
                                count = count + character_length_tens[5];
                                current_count = current_count + character_length_tens[5];
                                break;
                            case '7':
                                count = count + character_length_tens[6];
                                current_count = current_count + character_length_tens[6];
                                break;
                            case '8':
                                count = count + character_length_tens[7];
                                current_count = current_count + character_length_tens[7];
                                break;
                            case '9':
                                count = count + character_length_tens[8];
                                current_count = current_count + character_length_tens[8];
                                break;
                        }
                        switch (stringx[2]) //ones digit
                        {
                            case '0':
                                count = count + character_length_ones[0];
                                current_count = current_count + character_length_ones[0];
                                break;
                            case '1':
                                count = count + character_length_ones[1];
                                current_count = current_count + character_length_ones[1];
                                break;
                            case '2':
                                count = count + character_length_ones[2];
                                current_count = current_count + character_length_ones[2];
                                break;
                            case '3':
                                count = count + character_length_ones[3];
                                current_count = current_count + character_length_ones[3];
                                break;
                            case '4':
                                count = count + character_length_ones[4];
                                current_count = current_count + character_length_ones[4];
                                break;
                            case '5':
                                count = count + character_length_ones[5];
                                current_count = current_count + character_length_ones[5];
                                break;
                            case '6':
                                count = count + character_length_ones[6];
                                current_count = current_count + character_length_ones[6];
                                break;
                            case '7':
                                count = count + character_length_ones[7];
                                current_count = current_count + character_length_ones[7];
                                break;
                            case '8':
                                count = count + character_length_ones[8];
                                current_count = current_count + character_length_ones[8];
                                break;
                            case '9':
                                count = count + character_length_ones[9];
                                current_count = current_count + character_length_ones[9];
                                break;
                        }
                    }
                    Console.WriteLine(i + " has a count of " + current_count); // this line was useful for checking
                    current_count = 0;
                }
            }
            Console.WriteLine(count);

        }
    }
}
