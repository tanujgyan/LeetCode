﻿using System;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwoSumDriverCode();
            //ReverseIntegerDriverCode();
            //PalindromeIntegerDriverCode();
            //RomanNumeralsDriverCode();
            //FindLongestCommonPrefixDriverCode();
            ValidParenthesesDriverCode();
        }
        static void TwoSumDriverCode()
        {
            TwoSum twoSum = new TwoSum();
            int[] nums = new int[] { 3, 4, -3, 90 };
            int target = 0;
            var result = twoSum.TwoSumCalculator(nums, target);
            var dictResult = twoSum.TwoSumCalculatorUsingDictionary(nums, target);
            result.ToList().ForEach(x => Console.WriteLine(x));
            dictResult.ToList().ForEach(x => Console.WriteLine(x));
        }
        static void ReverseIntegerDriverCode()
        {
            ReverseInteger reverseInteger = new ReverseInteger();
            Console.WriteLine(reverseInteger.ReverseIntegerUsingStringConversion((int)Math.Pow(2, 33)));
            Console.WriteLine(reverseInteger.ReverseIntegerUsingStringConversionNoLINQ(-321));
        }
        static void PalindromeIntegerDriverCode()
        {
            PalindromeInteger palindromeInteger = new PalindromeInteger();
            Console.WriteLine(palindromeInteger.IsPalindromeInteger(1234));
        }
        static void RomanNumeralsDriverCode()
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Console.WriteLine(romanNumerals.RomanToInt("MDCXCV"));
        }
        static void FindLongestCommonPrefixDriverCode()
        {
            LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
          Console.WriteLine(longestCommonPrefix.FindLongestCommonPrefix(new string[] { "ab","a" }));
        }
        static void ValidParenthesesDriverCode()
        {
            ValidParentheses validParentheses = new ValidParentheses();
            Console.WriteLine(validParentheses.CheckIfValidParentheses("["));
        }
    }
}
