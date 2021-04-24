using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Recursion_Problems
{
    class CountConsonantsClass
    {
        public int CountConsonants(string s, int count=0,int index=0)
        {
            if(index==s.Length)
            {
                return count;
            }
            if(char.IsLetter(s[index]) && s[index]!='a' && s[index] != 'e' && s[index] != 'i' && s[index] != 'o' && s[index] != 'u')
            {
                count++;
            }
            return CountConsonants(s, count, index + 1);
        }
    }
}
