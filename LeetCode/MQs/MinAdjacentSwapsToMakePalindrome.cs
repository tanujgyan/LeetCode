using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Microsoft_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/discuss/interview-question/351783/
    /// </summary>
    public class MinAdjacentSwapsToMakePalindrome
    {
        /**
     * Algorithm:
     *     1. First check the given string is a jumbled/shuffled palindrome or not.
     *     2. Next have two pointers p1 at 0 and p2 at s.length - 1 and start iterating.
     *     3. If chars at both the pointers are same then just shrink the window (increase the p1 and decrease the p2).
     *     4. or Else
     *          a. find the matching pair and swap the char to p2 index (increase swap count while swapping) and finally shrink the window.
     *          b. if not found just swap once with adjacent index and increase the swap count (do not shrink the window here)
     *     5. Print the Swap Count
     *
     * Time Complexity: O(n) to find Palindrome + [ O(n) for two pointer iteration * O(n) for checking and swapping ] so => O(n^2)
     * Space Complexity: O(n)
     *
     */

        public bool IsPossiblePalindrome(string s)
        {
            int odd = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 1);
                }
                else
                {
                    dict[s[i]]++;
                }
            }
            foreach(var element in dict)
            {
                if(element.Value%2!=0)
                {
                    odd++;
                    if(odd>1)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        public int AdjacentSwaps(string s)
        {
            char[] c = s.ToCharArray();
            char[] reverse = s.ToCharArray();
            Array.Reverse(reverse);
            if (s.Equals(reverse.ToString()))
            {
                return 0;
            }
            if (IsPossiblePalindrome(s))
            {
                int swaps = 0;
                int j = c.Length - 1;

                for (int i = 0; i < c.Length;)
                {
                    if (j < 0)
                    {
                        break;
                    }
                    if (c[i] == c[j])
                    {
                        i++;
                        j--;
                    }
                    else
                    {
                        if (s.Contains(c[i]) && s.LastIndexOf(c[i]) > i)
                        {
                            int index = s.LastIndexOf(c[i]);
                            while (j < index - 1)
                            {
                                char temp = c[index];
                                c[index] = c[index + 1];
                                c[index + 1] = temp;
                                swaps++;
                            }
                            i++;
                            j--;
                        }
                        else
                        {
                            char temp = c[i];
                            c[i] = c[i + 1];
                            c[i + 1] = temp;
                            swaps++;
                        }
                    }
                }
                if (c == reverse)
                {
                    return swaps;
                }
                
            }
            return -1;
        }
        
    }
}
