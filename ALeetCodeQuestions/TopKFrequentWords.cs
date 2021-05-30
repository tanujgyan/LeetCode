using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/top-k-frequent-words/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// the idea is to save words in dictionary with their frequency
    /// //then sort the values to get most frequent words and then select top k
    /// </summary>
    class TopKFrequentWords
    {
        public List<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> list = new List<string>();
            //fill up the dictionary
            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                }
                else
                {
                    dict[word]++;
                }
            }
            dict= dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            for(int i=0;i<k;i++)
            {
                list.Add(dict.ElementAt(i).Key);
            }
            return list;
        }
    }
}
