using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ALQ
{
    class WordBreak2
    {
        List<string> result = new List<string>();
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            foreach(var word in wordDict)
            {
                int length = word.Length;
                List<string> tempResult;
                if(length<= s.Length && s.Substring(0,length)==word)
                {
                    tempResult = new List<string>() { word};
                    WordBreakHelper(s, wordDict, word, 0, new StringBuilder(word),tempResult);
                }
            }
            return result;
        }
        private void WordBreakHelper(string s, IList<string> wordDict, string starterWord, int index, StringBuilder sb,List<string> tempResult)
        {
            if(sb.Length==s.Length && sb.ToString()==s)
            {
                StringBuilder tempSb = new StringBuilder();
                foreach (var r in tempResult)
                {
                    tempSb.Append(r);
                    tempSb.Append(" ");
                }
                tempSb.Remove(tempSb.Length - 1, 1);
                result.Add(tempSb.ToString());
                return;
            }
            if(sb.Length>s.Length)
            {
                return;
            }
            for (int i = 0; i < wordDict.Count; i++)
            {
                index = sb.Length;
                sb.Append(wordDict[i]);
              //  tempResult.Append(" ");
                tempResult.Add(wordDict[i]);
                
                if (sb.Length <= s.Length && s.Substring(0, sb.Length) == sb.ToString())
                {
                    WordBreakHelper(s, wordDict, starterWord, index, sb,tempResult);
                }
                sb.Remove(index, wordDict[i].Length);
                //tempResult.Remove(index, wordDict[i].Length + 1);
                tempResult.RemoveAt(tempResult.Count - 1);
            }
        }
    }
}
