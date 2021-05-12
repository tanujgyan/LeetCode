using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Aditya_Verma
{
    class PalindromicPartitioning
    {
        public int NumberOfCuts(string s)
        {
            var r = NumberOfCutsHelper(s, 0, s.Length - 1);
            return r;
        }
        public int NumberOfCutsHelper(string s, int i, int j)
        {
            
            if (i>=j)
            {
                return 0;
            }
            if(IsPalindrome(s.Substring(i,j-i+1)))
            {
                return 0;
            }
            int result = Int32.MaxValue;
            for (int k = i; k < j; k++)
            {
                result = Math.Min(NumberOfCutsHelper(s, i, k) + NumberOfCutsHelper(s, k + 1, j) + 1, result);
                
            }
            return result;
        }
        public bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length-1;
            while(i<j)
            {
                if(s[i]!=s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
