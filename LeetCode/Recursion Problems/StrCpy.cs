using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Recursion_Problems
{
    class StrCpy
    {
        //this assumes that destination string will be greater or equal to source
        public string strCpyMethod(string s1, string s2, int current)
        {

            //base condition
            if (current>= s1.Length && current>=s2.Length)
            {
                return s2;
            }
            if (current < s1.Length)
            {
                char[] c = s2.ToCharArray();
                c[current] = s1[current];
                s2 = new string(c);
            }
            else
            {
                char[] c = s2.ToCharArray();
                c[current] = char.MinValue;
                s2 = new string(c);
            }
           return strCpyMethod(s1, s2, current + 1);
            
        }
    }
}
