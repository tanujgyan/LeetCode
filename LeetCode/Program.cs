using System;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSumDriverCode();
        }
        static void TwoSumDriverCode()
        {
            TwoSum twoSum = new TwoSum();
            int[] nums = new int[] { 3,4,-3,90 };
            int target = 0;
            var result = twoSum.TwoSumCalculator(nums, target);
            var dictResult = twoSum.TwoSumCalculatorUsingDictionary(nums, target);
            result.ToList().ForEach(x => Console.WriteLine(x));
            dictResult.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
