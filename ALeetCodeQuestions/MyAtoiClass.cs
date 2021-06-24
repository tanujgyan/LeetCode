using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/string-to-integer-atoi/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea is to first use a helper method to check if string is positive or negative and valid or invalid
    /// We will also check and return the length of valid part of string
    /// then start parsing string from tail and use decimal system to convert it to number
    /// use double and keep checking if the result is between min and max value if not throw and exception and return results
    /// </summary>
    class MyAtoiClass
    {
        public int MyAtoi(string s)
        {
            s = s.TrimStart();
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int lengthOfNumber = FindTheNumberOfValidCharacters(s, out string integerType, out string modifiedString);
            double result = 0;
            if (integerType == "not an integer")
            {
                return 0;
            }
            try
            {
                int j = 0;
                for (int i = lengthOfNumber - 1; i >= 0; i--)
                {
                    result += char.GetNumericValue(modifiedString[i]) * Math.Pow(10, j);
                    if (result > int.MaxValue || result < int.MinValue)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    j++;
                }
                if (integerType == "negative")
                {
                    result *= -1;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                if (integerType == "negative")
                {
                    result = int.MinValue;
                }
                else
                {
                    result = int.MaxValue;
                }
            }
            return (int)result;

        }
        private int FindTheNumberOfValidCharacters(string s, out string integerType,out string modifiedString)
        {
            int start = 0;
            int result = 0;
            string temp = "";
            if (s[0] == '+')
            {
                temp = "positive";
                s = s.Substring(1);
            }
            else if (s[0] == '-')
            {
                temp = "negative";
                s = s.Substring(1);
            }
            else if (!char.IsDigit(s[0]))
            {
                integerType = "not an integer";
                modifiedString = "";
                return 0;
            }
            while (start < s.Length)
            {
                if (char.IsDigit(s[start]))
                {
                    result++;
                    start++;
                }
                else
                {
                    break;
                }
            }
            integerType = temp;
            modifiedString = s;
            return result;
        }
    }
}
