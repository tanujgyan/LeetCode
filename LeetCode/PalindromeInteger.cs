using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class PalindromeInteger
    {
        /// <summary>
        /// Tried this with for, while and foreach
        /// foreach gives the best performance
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindromeInteger(int x)
        {
            string tempPositive = "";
            //negative numbers wont work as -222 they will revert to 222- 
            if(x<0)
            {
                return false;
            }
            var positive = x.ToString();
            foreach(char c in positive)
            {
                tempPositive = c+ tempPositive;
            }
            if (tempPositive.Equals(positive))
                return true;
            return false;
        }
    }
}
