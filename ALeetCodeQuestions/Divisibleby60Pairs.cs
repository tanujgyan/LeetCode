using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea behind this algorithm is backed up by simple maths. If we divide a number by 60 and remainder is 0 then any two numbers
    /// like that when added will give a number divisible by 60, simillarly if modulo is 30 take two numbers like that add them and 
    /// divisble by 60 number is obtained
    /// For others take the number and look for key with 60-number. Then take the count of list in values and multiply them to get total
    /// pairs
    /// </summary>
    class Divisibleby60Pairs
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int count = 0;
            foreach(var t in time)
            {
                if(!dict.ContainsKey(t%60))
                {
                    dict.Add(t % 60, new List<int>() { t });
                }
                else
                {
                    dict[t % 60].Add(t);
                }
            }
            while(dict.Count>0)
            {
                if(dict.ElementAt(0).Key==0 || dict.ElementAt(0).Key==30)
                {
                    count += ((dict.ElementAt(0).Value.Count * (dict.ElementAt(0).Value.Count - 1)) / 2);
                    dict.Remove(dict.ElementAt(0).Key);
                }
                else
                {
                    if(dict.ContainsKey(60-dict.ElementAt(0).Key))
                    {
                        int key1 = dict.ElementAt(0).Key;
                        int key2 = 60 - dict.ElementAt(0).Key;
                        count += (dict.ElementAt(0).Value.Count * dict[60 - dict.ElementAt(0).Key].Count);
                        dict.Remove(key1);
                        dict.Remove(key2);
                    }
                    else
                    {
                        dict.Remove(dict.ElementAt(0).Key);
                    }
                }

            }
            return count;
        }
        
    }
}
