using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class ReverseVowelsClass
    {
        public string ReverseVowels(string s)
        {
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            StringBuilder sb = new StringBuilder(s);
            
           
            int i = 0;
            int j = s.Length - 1;
            while(i<j)
            {
                //start from the start pointer and keep moving forward till you reach a vowel
                while(i<j && !vowels.Contains(sb[i]))
                {
                    i++;
                }
                //once a start pointer is found go to the end and keep moving backward till we find another vowel
                while(i<j && !vowels.Contains(sb[j]))
                {
                    j--;
                }
                //switch the two characters
                var temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;
                //repeat the process till we reach the middle of the string
                i++;
                j--;
            }
            return sb.ToString();

        }
    }
}
