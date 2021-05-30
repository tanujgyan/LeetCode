using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/repeated-string-match/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea behind this algorithm is to parse the a string characters 1 by 1 and finding a matching character in b.
    /// Once we find a matching character we need to start printing a starting from matching character for the length of b
    /// If we find a mismatch in between we can return -1 
    /// Then we take the next char from a and repeat the process again
    /// We will keep doing this all the characters from a are matched against b
    /// If we are not able to find any matches and all returned values are -1 we will return -1 as answer
    /// 
    /// To get the count when we are repeating a's character in cyclic loop we will increment the count by 1 whenever a reaches 
    /// its end will be started again
    /// To cover an edge case where a stops in middle because b is exhausted we will check if pointer >0
    /// </summary>
    class RepeatedStringMatch
    {
        public int RepeatedStringMatchMethod(string a, string b)
        {
            int pointer = -1;
            int result = 0;
            if(a==b)
            {
                return 1;
            }
            //find the starting position for a
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==b[0])
                {
                    pointer = i;
                    result = MatchRepeatHelper(a, b, pointer);
                    if(result!=-1)
                    {
                        break;
                    }
                }
            }
            if(pointer==-1)
            {
                return -1;
            }
            return result; 
        }
        private int MatchRepeatHelper(string a, string b, int pointer)
        {
            int result = 0;
            for (int i = 0; i < b.Length; i++)
            {

                if (a[pointer] == b[i])
                {
                    pointer++;
                    if (pointer == a.Length)
                    {
                        result++;
                        pointer = 0;
                    }
                }
                else
                {
                    result = -1;
                    break;
                }
            }
            //edge case if a stops in middle because b gets exhausted
            if (pointer != 0 && result!=-1)
            {
                result++;
            }
            return result;
        }
        
        
    }
}

