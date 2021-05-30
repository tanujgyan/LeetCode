using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/1148760/items-in-containers-amazon-oa
    /// </summary>
    public class ItemsInContainer
    {
        /// <summary>
        /// The algorithm for this question is based on DP but in a little bit different way
        /// We have to fill the POTENTIAL numbers in a dp array
        /// I call them potential because its not necessary that they will pan out 
        /// When we encounter a | it means no stars and when we encounter * we increase the number by 1 
        /// We first parse the string and if we get * we increase the count by 1 else keep it same
        /// We will then have a potential memory in front of us its potential because we have not yet decided if it will form a part of solution
        /// reason being to be a part of solution it has to have an opening | and a closing |
        /// When we actually start working on indicies we will look for a start | and an end | and we will already have the count so
        /// we dont have to bother about counting it again
        /// </summary>
        /// <param name="s"></param>
        /// <param name="startIndices"></param>
        /// <param name="endIndices"></param>
        /// <returns></returns>
        public List<int> NumberOfItems(string s, List<int> startIndices, List<int> endIndices)
        {
            List<int> result = new List<int>();
            //start filling your potential array
            int[] dpArray = new int[s.Length+1];
            dpArray[0] = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]=='|')
                {
                    dpArray[i + 1] = dpArray[i];
                }
                else
                {
                    dpArray[i + 1] = dpArray[i] + 1;
                }
            }
            for(int i=0;i<startIndices.Count;i++)
            {
                int startIndex = startIndices[i]-1;
                int endIndex = endIndices[i]-1;
                if(s[startIndex]!='|')
                {
                    startIndex++;
                }
                if(s[endIndex] != '|')
                {
                    endIndex--;
                }
                result.Add(dpArray[endIndex + 1] - dpArray[startIndex + 1]);
            }
            return result;
        }
    }
}
