using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LengthOfLastWordClass
    {
        public int LengthOfLastWord(string s)
        {
            int sum = 0;
            for(int i=s.Length-1;i>=0;i--)
            {
                if(s[i]!=' ')
                {
                    
                    sum++;
                }
                else
                {
                    if (sum == 0)
                    {
                        continue;
                    }
                    break;
                }
            }
            return sum;
        }
    }
}
