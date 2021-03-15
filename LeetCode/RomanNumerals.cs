using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RomanNumerals
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            switch (s.Length)
            {
                case 1:
                    result = RomanDecoderOneString(Convert.ToChar(s));
                    break;
                case 2:
                    int i = RomanDecoderTwoString(s);
                    result = i== -1 ? SplitAndDecodeRomanNumeral(s) : i;
                    break;
                default:
                    result = SplitAndDecodeRomanNumeral(s);
                    break;
            }
            return result;

        }
        /// <summary>
        /// The idea is to split the string and check if the first two letters are one of the special cases 
        /// If not simply add it and coninue processing the string.
        /// If it is special case then increment the counter by 1 as two letters are being processed at same time
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int SplitAndDecodeRomanNumeral(string s)
        {
            int sum = 0;
            int romanDecoderTwoString = 0;
            for (int i=0;i<s.Length;i++)
            {
                if(i+1<s.Length)
                    romanDecoderTwoString = RomanDecoderTwoString(s[i].ToString() + s[i + 1].ToString());
                //if not  a special case or we have reached the end of string
                if (romanDecoderTwoString == -1|| i+1== s.Length)
                {
                    sum = sum + RomanDecoderOneString(s[i]);

                }
                else
                {
                    sum = sum + romanDecoderTwoString;
                    i++;
                }
            }
            return sum;
        }
        public int RomanDecoderOneString(char c)
        {
            if (c == 'I')
                return 1;
            else if (c == 'V')
                return 5;
            else if (c == 'X')
                return 10;
            else if (c == 'L')
                return 50;
            else if (c == 'C')
                return 100;
            else if (c == 'D')
                return 500;
            else if (c == 'M')
                return 1000;
            //thic indicatec an error
            return -1;
        }
        public int RomanDecoderTwoString(string s)
        {
            if (s == "IV")
                return 4;
            else if (s == "IX")
                return 9;
            else if (s == "XL")
                return 40;
            else if (s == "XC")
                return 90;
            else if (s == "CD")
                return 400;
            else if (s == "CM")
                return 900;
            //this indicates an error
            return -1;
        }
    }
}

