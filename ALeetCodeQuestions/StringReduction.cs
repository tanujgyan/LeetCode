using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://www.hackerrank.com/challenges/string-reduction/problem
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea behind this question is to find the best possible position to change the strings
    /// There are 3 possiblities 
    /// 1. corner two characters are different -- worst case
    /// 2. the character on left obtained after switch is different OR character on right after switch is different - second best scenario
    /// 3. the character on left obtained after switch is different AND character on right after switch is different - best scenario
    /// 
    /// We will process the string for best scenarios first followed by second best and worst scenarios
    /// </summary>
    class StringReduction
    {
        public int stringReduction(string s)
        {
            bool reductionPossible = true;
            int bestPosition = Int32.MaxValue;
            bool secondBestFound = false;
            while (reductionPossible)
            {
                
                for (int i = 0; i < s.Length; i++)
                {
                    if (i + 1 <= s.Length - 1 && s[i] != s[i + 1])
                    {
                        char potentialChar = FindPotentialChar(s[i], s[i + 1]);
                        if ((i - 1 >= 0 && s[i - 1] != potentialChar) && (i + 2 <= s.Length - 1 && s[i + 2] != potentialChar))
                        {
                            reductionPossible = true;
                            bestPosition = i;
                            break;
                        }
                        else if ((i - 1 >= 0 && s[i - 1] != potentialChar) || (i + 2 <= s.Length - 1 && s[i + 2] != potentialChar))
                        {
                            reductionPossible = true;
                            bestPosition = i;
                            secondBestFound = true;
                        }
                        else
                        {
                            reductionPossible = true;
                            if (!secondBestFound)
                            {
                                bestPosition = i;
                            }
                        }

                    }
                }
                if(bestPosition!=Int32.MaxValue)
                {
                    StringBuilder sb = new StringBuilder(s);
                    sb[bestPosition] = FindPotentialChar(s[bestPosition], s[bestPosition + 1]);
                    sb.Remove(bestPosition + 1, 1);
                    bestPosition = Int32.MaxValue;
                    secondBestFound = false;
                    s = sb.ToString();
                }
                else
                {
                    break;
                }
            }
            return s.Length;
        }
        private char FindPotentialChar(char c1, char c2)
        {
            if(c1!='c' && c2!='c' )
            {
                return 'c';
            }
            else if(c1!='b' && c2!='b')
            {
                return 'b';
            }
            return 'a';
        }
    }
}
