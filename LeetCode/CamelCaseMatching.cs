using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/camelcase-matching/
    /// </summary>
    class CamelCaseMatching
    {
        /// <summary>
        /// Thought process summary
        /// 1. We need to run a loop to consider all the queries - that is the outer for loop
        /// 2. We need to take strings from the array and process each character
        ///     We will assign a counter for pattern because when we process the string it should match the pattern in order
        ///     a. When we process a character there can be two scenarios either it can be upper case or lower case
        ///     b. If upper case is encountered it must match the character of the pattern we are currently looking for.
        ///         If not we can break from loop and add false to result array
        ///         If yes we should move the pattern pointer by 1 and increment the matchFoundCounter by 1 (we will match this with pattern
        ///         length at the end)
        ///         If we encounter an upper case character after pattern matching is done we should set the flag of not matched to false and break 
        ///         out of loop. 
        ///     c. If we encounter lower case letter we can see if it matches with the pattern being processed if not continue the loop
        ///         If a match is found increment the match found counter and patterncounter
        /// </summary>
        /// <param name="queries"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>

        public IList<bool> CamelMatch(string[] queries, string pattern)
        {
            int len = queries.Length;
            int patternLength = pattern.Length;
            List<bool> result = new List<bool>();
            for (int i = 0; i < len; i++)
            {
                int patternCounter = 0;
                int matchfoundCounter = 0;
                bool extraUpperCaseFound = false;
                foreach (char c in queries[i])
                {
                    //if we encounter an upper case character
                    if(Char.IsUpper(c))
                    {
                        //it comes after the pattern matching is complete
                        if(patternCounter >= patternLength)
                        {
                            extraUpperCaseFound = true;
                            break;
                        }
                        //the pattern character we are looking for is not same as the upper case character that is being processed
                        if (!c.Equals(pattern[patternCounter]))
                        {
                            extraUpperCaseFound = true;
                            break;
                        }
                        else
                        {
                            matchfoundCounter++;
                            patternCounter++;
                        }
                    }
                    //if the character being processed is lower case
                    else if (patternCounter < patternLength && c.Equals(pattern[patternCounter]))
                    {
                        matchfoundCounter++;
                        patternCounter++;
                    }
                }
                //if match was found and no extra upper case letters was found
                if(matchfoundCounter == patternLength && extraUpperCaseFound==false)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }

            }
            return result;
        }
    }
}
