using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hacker_Rank
{
    class NumberOfCamelCase
    {
        public static int camelcase(string s)
        {
            int len = s.Length;
            int result = 1;
            if(string.IsNullOrEmpty(s))
            {
                return 0;
            }
            if(!Char.IsLower(s[0]))
            {
                return 0;
            }
            result = 1;
            for(int i=1;i<s.Length;i++)
            {
                if(Char.IsUpper(s[i]))
                {
                    result++;
                }
            }
            return result;
        }
    }
}
