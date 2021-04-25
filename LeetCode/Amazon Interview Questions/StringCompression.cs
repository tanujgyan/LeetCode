using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/string-compression/submissions/
    /// </summary>
    class StringCompression
    {
        public int Compress(char[] chars)
        {
            StringBuilder stringBuilder = new StringBuilder();
            char c = '\0';
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                //check for the first char
                if (c == '\0')
                {
                    c = chars[i];
                    count++;
                }
                else
                {
                    //if  a new char comes append the previous char to stringbuilder
                    if (chars[i] != c)
                    {
                        stringBuilder.Append(c);
                        //append count only if >1
                        if (count > 1)
                            stringBuilder.Append(count);

                        //set the char to new character
                        c = chars[i];
                        //set count t 1
                        count = 1;
                    }
                    //if same character comes increment the count
                    else if(chars[i]==c)
                    {
                        count++;
                    }
                }
            }
            //at the end take the last character and append it
            stringBuilder.Append(c);
            if (count > 1)
                stringBuilder.Append(count);
            //process the string builder and replaces chars array values.
            for(int i=0; i<stringBuilder.Length;i++)
            {
                chars[i] = stringBuilder[i];
            }
            return stringBuilder.Length;
        }
    }
}
