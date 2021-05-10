using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-words-in-a-string/
    /// </summary>
    class ReverseWordsClass
    {
        public string ReverseWords(string s)
        {
            string[] arr = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int startPointer = 0;
            int endPointer = arr.Length - 1;
            while(startPointer<endPointer)
            {
                string temp = arr[startPointer];
                arr[startPointer] = arr[endPointer];
                arr[endPointer] = temp;
                startPointer++;
                endPointer--;
            }
            return String.Join(" ", arr);
        }
    }
}
