using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// This code takes 96 ms
    /// It uses the reverse function of Linq to revert the string and then using try parse gets the result or 0
    /// </summary>
    class ReverseInteger
    {
        public int ReverseIntegerUsingStringConversion(int x)
        {
            string positive = "";
            string negative = "";
            int result = 0;
            if (x>= 0)
            {
                positive =String.Join("", x.ToString().Reverse());
                result = Int32.TryParse(positive, out result) == false ? 0 : result;
            }
            else if (x<0)
            {
                negative = "-" + String.Join("",x.ToString().Substring(1).Reverse());
                result = Int32.TryParse(negative, out result) == false ? 0 : result;
            }
            return result;
            
        }

        /// <summary>
        /// This code takes 48 ms 
        /// It uses for loop revert the string and then using try parse gets the result or 0
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int ReverseIntegerUsingStringConversionNoLINQ(int x)
        {
            string positive="",tempPositive = "";
            string negative="",tempNegative = "";
            int result = 0;
            if (x >= 0)
            {
                positive = x.ToString();
                for(int i=positive.Length-1;i>=0;i--)
                {
                    tempPositive = tempPositive + positive[i];
                }
                result = Int32.TryParse(tempPositive, out result) == false ? 0 : result;
            }
            else if (x < 0)
            {
                negative =  x.ToString().Substring(1);
                for (int i = negative.Length - 1; i >= 0; i--)
                {
                    tempNegative = tempNegative + negative[i];
                }
                result = Int32.TryParse("-"+tempNegative, out result) == false ? 0 : result;
            }
            return result;

        }
    }
}
