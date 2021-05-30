using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ALQ
{
    /// <summary>
    /// https://leetcode.com/problems/reorder-data-in-log-files/
    /// </summary>
    class ReorderDataInLogFiles
    {
       
        public string[] ReorderLogFiles(string[] logs)
        {
            List<string> result2 = new List<string>();
            List<KeyValuePair<string, string>> letterDict = new List<KeyValuePair<string, string>>();
            int inputLength = logs.Length;
            for (int i = 0; i < inputLength; i++)
            {
                //using regex to check if its digit or letter
                if(letterOrDigit(logs[i])=='d')
                {
                    result2.Add(logs[i]);
                }
                else
                {
                    var s = CreateKeyValuePairs(logs[i]);
                    KeyValuePair.Create(s[0], s[1]);
                    
                    letterDict.Add(KeyValuePair.Create(s[0], s[1]));
                }
            }
            //sort the letter lexographically
            var collection = letterDict.OrderBy(x => x.Value,StringComparer.Ordinal).ThenBy(x => x.Key, StringComparer.Ordinal);
            //convert it to string list
            var result1 = collection.Select(x => x.Key + " " + x.Value).ToList();
            //merge and return result
            result1.AddRange(result2);
            return result1.ToArray();
        }
        private string[] CreateKeyValuePairs(string s)
        {
            string[] retVal = new string[2];
            int index = s.IndexOf(' ');
            retVal[0]= s.Substring(0, index);
            retVal[1] = s.Substring(index + 1);
            return retVal;
        }
        private char letterOrDigit(string s)
        {
            if (Regex.IsMatch(s.Split(" ")[1], "^[0-9]*$"))
            {
                return 'd';
            }
            return 'l';
        }
        
    }
}
