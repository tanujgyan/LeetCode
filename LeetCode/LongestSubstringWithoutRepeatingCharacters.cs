using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// Start the outside loop and store the first character in tempstring.
        /// Start the inner loop with i+1 and keep checking tempstring contains s[j] if not append the character and increase tempmax
        /// if tempstring contains s[j] set i to where the first s[j] was found because there is no point in checking before that substring will 
        /// always be smaller. Remember j is relative to i so to set the i correctly we need to add i to index of s[j] to get the actual index
        /// Break and compare max to tempmax and assign whichever is bigger.
        /// Continue the loop till the number of characters left is more than max because there is no point in calculating if number of characters is less
        /// as we have already achieved max.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            string tempstring = ""; int max = 0, tempmax = 0;
            int i = 0;
            
                for (; i < s.Length; i++)
                {
                if ( s.Length-i > max)
                {
                    tempstring = s[i].ToString();
                    tempmax++;
                    for (int j = i + 1; j < s.Length; j++)
                    {

                        if (!tempstring.Contains(s[j]))
                        {
                            tempstring = tempstring + s[j].ToString();
                            tempmax++;
                        }
                        else
                        {
                            //get the actual index as j is a relative index
                            i = i + tempstring.IndexOf(s[j]);
                            break;
                        }

                    }
                    if (tempmax > max)
                        max = tempmax;

                    tempmax = 0;
                }
                else
                    break;
            }

            return max;
        }

    }
}
