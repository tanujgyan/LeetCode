using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// Given a string s, a k duplicate removal consists of choosing k adjacent and equal letters from s and removing them causing the left and the right side of the deleted substring to concatenate together.

   /// We repeatedly make k duplicate removals on s until we no longer can.

   /// Return the final string after all such duplicate removals have been made.

   // It is guaranteed that the answer is unique.

//    Input: s = "abcd", k = 2
//      Output: "abcd"
//    Explanation: There's nothing to delete.

//    Input: s = "deeedbbcccbdaa", k = 3
//      Output: "aa"
//  Explanation: 
//  First delete "eee" and "ccc", get "ddbbbdaa"
//  Then delete "bbb", get "dddaa"
//  Finally delete "ddd", get "aa"
    /// </summary>
    class RemoveAllAdjacentDuplicatesInString2
    {
        /// <summary>
        /// Initialize the temp with first character
        /// Start looping and check if temp is equal to index of string if yes then add to temp.
        /// Check if length is reached to k if yes delete the substring and set i=0
        /// if temp is not equal to index of string and length of temp is not k set temp to current index
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public string RemoveDuplicates(string s, int k)
        {
            
            string temp = "";
            if (s.Length>0)
            {
                temp = s[0].ToString();
            }
            for (int i=1;i<s.Length;i++)
            {
                
                if(temp[0]==s[i])
                {
                    temp += s[i];
                }
                else if(temp[0]!=s[i] && temp.Length<k)
                {
                    temp = "";
                    temp = s[i].ToString();
                }
                if (temp.Length == k)
                {
                    s= s.Remove(i - k+1, k);
                    i = 0;
                    temp = s[i].ToString();
                }

            }
            return s;
        }
    }
}
