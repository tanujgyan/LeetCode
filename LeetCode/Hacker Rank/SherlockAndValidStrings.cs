using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Hacker_Rank
{
    class SherlockAndValidStrings
    {
        public static string isValid(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            
            if(dict.Count==1)
            {
                return "YES";
            }
            //if there are two elements either they should have same frequency or difference of 1
            if (dict.Count == 2)
            {
                if (dict.ElementAt(1).Value - dict.ElementAt(0).Value == 0 || dict.ElementAt(1).Value - dict.ElementAt(0).Value == 1)
                {
                    return "YES";
                }
            }
            if (dict.Count >= 3)
            {
                int first = dict.ElementAt(0).Value;
                int last = dict.ElementAt(dict.Count - 1).Value;
                int f = 0, l = 0;
                //if first element and last frequency are same 
                if(first==last)
                {
                    return "YES";
                }
                //parse through each element in dictionary
                foreach(var element in dict)
                {
                    //if element found is not equal to first or last frequency return no
                    if(element.Value!=first && element.Value!=last)
                    {
                        return "NO";
                    }
                    //keep increasing the frequency of first 
                    if(element.Value==first)
                    {
                        f++;
                    }
                    //keep increasing the frequency of last 
                    else if (element.Value==last)
                    {
                        l++;
                    }
                    //if both go above 2 then we can't satisfy the condition
                    if(f>=2 && l>=2)
                    {
                        return "NO";
                    }
                }
                //if first element frequency is total-1 and difference between first and last frequency is 1
                //we can remove 1 element from last frequency to make it valid
                if(f==dict.Count-1 && l==1 && last-first==1)
                {
                    return "YES";
                }
                //if last element frequency is total-1 and first element is 1 we can remove that to make string valid
                else if(l==dict.Count-1 && f==1 && first==1)
                {
                    return "YES";
                }

            }
            return "NO";
        }
    }
}
