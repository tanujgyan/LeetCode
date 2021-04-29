using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hacker_Rank
{
    class AlternatingCharcatersClass
    {
        public static int alternatingCharacters(string s)
        {
            int len = s.Length;
            StringBuilder sb = new StringBuilder(s);
            char currentCharacter='\0';
            int removedChars = 0;
            for(int i=0;i<len;i++)
            {
                if(currentCharacter=='\0')
                {
                    currentCharacter = sb[i];
                }
                else
                {
                    if(sb[i]==currentCharacter)
                    {
                        sb.Remove(i, 1);
                        len--;
                        i--;
                        removedChars++;
                    }
                    else
                    {
                        currentCharacter = sb[i];
                    }
                }
            }
            return removedChars;
        }
    }
}
