using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class LetterCombinationOfPhoneNumberWithDFS
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            string[] map = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            if(string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }
            LetterCombinationDFS(digits, map, result, new StringBuilder(), 0);
            return result;
        }
        public List<string> LetterCombinationDFS(string digits, string[] map, List<string> result, StringBuilder sb,int index)
        {
            if(index==digits.Length)
            {
                result.Add(sb.ToString());
               
                return result;
            }
            var c = Convert.ToInt32(digits[index].ToString());
            //this loop will feed the characters corrosponding to number 1 by 1 
            for(int i=0;i<map[c].Length;i++)
            {
                sb.Append(map[c][i]);
                //after appending the first character to string builder take the second number and start processing again
                //when you reach to end one full branch will be processed.
                //this is like processing the left most branch
                LetterCombinationDFS(digits, map, result, sb, index + 1);
                // remove the last processed letter so that we can add the next last letter to string builder.
                sb.Remove(sb.Length-1, 1);
            }
            return result;
        }
    }
}
