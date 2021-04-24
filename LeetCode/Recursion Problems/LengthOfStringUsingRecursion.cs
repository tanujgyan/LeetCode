using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Recursion_Problems
{
    class LengthOfStringUsingRecursion
    {
        
        public int stringLength(string s, int count=0, int index=0)
        {
            
            // if we reach at the end of the string
            if (s.Equals(""))
                return 0;
            else
                return stringLength(s.Substring(1)) + 1;
        }
    }
}
