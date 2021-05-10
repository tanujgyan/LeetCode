using System;
using System.Collections.Generic;
using System.Text;

namespace DP
{
    class WordBreakClass
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            int inputLength = s.Length;
            bool[] dparray = new bool[inputLength + 1];
            dparray[0] = true;
            for(int i=1;i<=inputLength;i++)
            {
                for(int j=0;j<i;j++)
                {
                    //in the dp array we store true/false
                    //at any point true represents that if we take all the characters before that its a valid string
                    //when we try and include a new character we check the character before that should be valid and the whole
                    //string should be valid 
                    //if not reduce the substring but every substring we check will be valid only if present in dict 
                    //and the index just before that is valid
                    if(dparray[j] && wordDict.Contains(s.Substring(j,i-j)))
                    {
                        dparray[i] = true;
                        break;
                    }
                }
            }
            return dparray[inputLength];
        }
    }
}
