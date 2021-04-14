using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ValidPalindromeClass
    {
        public bool IsPalindrome(string s)
        {
            char[] arr = s.ToCharArray();

            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c))));
            s = new string(arr);
            Array.Reverse(arr);
            string reverse = new string(arr);
            if (s.Equals(reverse ,StringComparison.InvariantCultureIgnoreCase))
                return true;
            return false;
        }
    }
}
