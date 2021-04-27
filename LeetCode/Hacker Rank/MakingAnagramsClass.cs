using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Hacker_Rank
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
    /// </summary>
    public class MakingAnagramsClass
    {
        public static void makeAnagram(string a, string b)
        {
            Dictionary<char, int> dictA = new Dictionary<char, int>();
            Dictionary<char, int> dictB = new Dictionary<char, int>();
            //save the chars and values as key pairs in dictionary
            for(int i=0;i<a.Length;i++)
            {
                if(!dictA.ContainsKey(a[i]))
                {
                    dictA.Add(a[i], 1);
                }
                else
                {
                    dictA[a[i]]++;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (!dictB.ContainsKey(b[i]))
                {
                    dictB.Add(b[i], 1);
                }
                else
                {
                    dictB[b[i]]++;
                }
            }
           
           
           int removedelements = 0;
           while(dictA.Count>0)
            {
                //if both dictA and dictB contains the same key. remove the number of extra elements
                if(dictB.Count>0 && dictB.ContainsKey(dictA.ElementAt(0).Key))
                {
                    removedelements += Math.Abs(dictA.ElementAt(0).Value - dictB[dictA.ElementAt(0).Key]);
                    dictB.Remove(dictA.ElementAt(0).Key);
                    dictA.Remove(dictA.ElementAt(0).Key);
                   
                   
                }
                //if dictA contains an extra key
                else if (dictB.Count > 0 && !dictB.ContainsKey(dictA.ElementAt(0).Key))
                {
                    removedelements += dictA.ElementAt(0).Value;
                    dictA.Remove(dictA.ElementAt(0).Key);
                   
                }
                //if there are leftovers after dictB has been fully processed
                else if( dictB.Count==0)
                {
                    removedelements += dictA.Values.Sum();
                    break;
                }
            }
           //if after fully processing dictB is still not empty
           if(dictB.Count>0)
            {
                removedelements += dictB.Values.Sum();
            }
            Console.WriteLine(removedelements);
        }
    }
}
