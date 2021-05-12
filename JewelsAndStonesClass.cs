using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class JewelsAndStonesClass
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int sum = 0;
            Dictionary<char, int> stoneDict = new Dictionary<char, int>();
            for(int i=0;i<stones.Length;i++)
            {
                if (!stoneDict.ContainsKey(stones[i]))
                    stoneDict.Add(stones[i], 1);
                else
                    stoneDict[stones[i]]++;
            }
            foreach(char c in jewels)
            {
                if (stoneDict.ContainsKey(c))
                    sum += stoneDict[c];
            }
            return sum;
        }
    }
}
