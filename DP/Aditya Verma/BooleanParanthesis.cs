using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Aditya_Verma
{
    public class BooleanParanthesis
    {
        int final = 0;
        public int NumberOfWays(string s)
        {
            var r = NumberOfWaysHelper(s, 0, s.Length - 1);
            return r;
        }
        public int NumberOfWaysHelper(string s, int i, int j)
        {
            if (j - i== 1 || i >= j)
            {
                return 0;
            }
           
            for (int k = i+1; k <= j-1; k += 2)
            {

                int result =NumberOfWaysHelper(s, i, k-1) + 
                    NumberOfWaysHelper(s, k + 1, j) + 
                    (Calculate(s[i], s[k], s[j],i,j) == true ? 1 : 0);
                final += result;
            }
            
            return final;

        }

        public bool Calculate(char c1, char operand, char c2,int i,int j)
        {
            if(j-i!=2)
            {
                return false;
            }
            bool b1 = false;
            bool b2 = false;
            bool result = false;
            if (c1 == 'T')
            {
                b1 = true;
            }
            else if (c1 == 'F')
            {
                b1 = false;
            }
            if (c2 == 'T')
            {
                b2 = true;
            }
            else if (c2 == 'F')
            {
                b2 = false;
            }
            if (operand == '|')
            {
                result = b1 || b2;
            }
            else if (operand == '&')
            {
                result = b1 && b2;
            }
            else if (operand == '^')
            {
                result = b1 ^ b2;
            }
            return result;
        }

    }
}

