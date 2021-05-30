using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/most-common-word/
    /// </summary>
    class MostCommonWordClass
    {

        public string MostCommonWord(string paragraph, string[] banned)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 ]");
            paragraph = rgx.Replace(paragraph, " ");
            var paraArray = paragraph.Split(" ");
            Dictionary<string, int> dict = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            for(int i=0;i<paraArray.Length;i++)
            {
               
                if (!banned.Any(s => s.IndexOf(paraArray[i], StringComparison.CurrentCultureIgnoreCase) > -1))
                {
                    if (!string.IsNullOrEmpty(paraArray[i]) && !dict.ContainsKey(paraArray[i]))
                    {
                        dict.Add(paraArray[i], 1);
                    }
                    else if (!string.IsNullOrEmpty(paraArray[i]) && dict.ContainsKey(paraArray[i]))
                    {
                        dict[paraArray[i]]++;
                    }
                }
            }
            return dict.OrderByDescending(x => x.Value).FirstOrDefault().Key.ToLower();
        }

        public string MostCommonWordAttempt2(string paragraph, string[] banned)
        {
            string retval = "";
            paragraph = paragraph.ToLower();
            StringBuilder sb = new StringBuilder();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int max = 0;

            foreach(var s in paragraph)
            {
                if(Char.IsLetter(s))
                {
                    sb.Append(s);
                }
                //if we reach here it means we reached the end of word
                else if(sb.Length>0)
                {
                    string val = sb.ToString();
                    if(!dict.ContainsKey(val) && !banned.Contains(val))
                    {
                        dict.Add(val, 1);
                        if(1>max)
                        {
                            max = 1;
                            retval = val;
                        }
                    }
                    else if(dict.ContainsKey(val) && !banned.Contains(val))
                    {
                        dict[val]++;
                        if(dict[val]>max)
                        {
                            retval = val;
                            max = dict[val];
                        }
                        
                    }
                    //clear the string builder after processing the word
                    sb.Clear();
                }
            }
            //check for any words that was not processed
            //this will happen when the last word in para will have no trailing spaces or punctuations
            if(sb.Length>0 && !banned.Contains(sb.ToString()))
            {
                if (!dict.ContainsKey(sb.ToString()) && !banned.Contains(sb.ToString()))
                {
                    dict.Add(sb.ToString(), 1);
                    if (1 > max)
                    {
                        max = 1;
                        retval = sb.ToString();
                    }
                }
                else if (dict.ContainsKey(sb.ToString()) && !banned.Contains(sb.ToString()))
                {
                    dict[sb.ToString()]++;
                    if (dict[sb.ToString()] > max)
                    {
                        retval = sb.ToString();
                        max = dict[sb.ToString()];
                    }

                }
            }
            return retval;
        }
    }
}
