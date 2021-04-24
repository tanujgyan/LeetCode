using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Recursion_Problems
{
    class FirstUpperCaseCharacter
    {
        public char FirstUpperCaseCharacterMethod(string s, int current = 0, List<char> list= null)
        {
            if(list!=null)
            {
                return list[0];
            }
            if(current == s.Length)
            {
                return char.MinValue;
            }
            if (!Char.IsUpper(s[current]))
            {
                return FirstUpperCaseCharacterMethod(s, current + 1, null);
            }
            else
            {
                list = new List<char>();
                list.Add(s[current]);
                return FirstUpperCaseCharacterMethod(s, current + 1, list);
            }
        }
    }
}
