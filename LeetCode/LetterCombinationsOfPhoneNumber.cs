using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// </summary>
    class LetterCombinationsOfPhoneNumber
    {
        Dictionary<char, string> mapping = new Dictionary<char, string>()
        {
            {'2',"abc" },
            {'3',"def" },
            {'4',"ghi" },
            {'5',"jkl" },
            {'6',"mno" },
            {'7',"pqrs" },
            {'8',"tuv" },
            {'9',"wxyz" }
        };

        
        public List<string> LetterCombinations(string digits)
        {
            List<string> tempList = new List<string>();
            List<string> result = new List<string>();
            if(string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }

            //prepare the base case if we had only one digit
            char c = (char)digits[digits.Length - 1];
            for(int i=0;i<mapping[c].Length;i++)
            {
                result.Add(mapping[c][i].ToString());
            }

            //this is the top loop which will give us the digits one by one
            for(int i=digits.Length-2;i>=0;i--) 
            {
                int l = mapping[digits[i]].Length;

                //everytime we start processing we will empty the result and add it to templist 
                if (result.Count != 0)
                {
                    tempList = new List<string>(result);
                    result = new List<string>();
                }
                //this is the second loop will give us the string representation of the digit we are trying to process
                for(int j=0;j<l;j++) 
                {
                    var temptemplist = tempList.ToArray();
                    // this is the inner most loop which will take one character from the string at a time and add it to the 
                    //current list
                    for(int k=0;k<tempList.Count;k++) 
                    {
                        tempList[k] = mapping[digits[i]][j].ToString() + tempList[k];
                    }
                    //save the current state of result
                    result.AddRange( tempList);
                    tempList = temptemplist.OfType<string>().ToList(); ;
                }
            }

            return result;
        }
    }
}
