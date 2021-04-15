using System;
using System.Collections.Generic;
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
            //ValidParenthesesDriverCode();
            //MergeSortedListsDriverCode();
            //RemoveDuplicatesFromSortedArrayDriverCode();
            //RemoveElementDriverCode();
            //  ImplementstrStrDriverCode();
            //SearchInsertPositionDriverCode();
            //LengthOfLastWordClassDriverCode();
            //PlusOneDriverCode();
            //AddBinaryDriverCode();
            //SquareRootDriverCode();
           //ClimbingStairsDriverCode();
            //RemoveDuplicateFromSortedListDriverCode();
            //MergeSortedArrayClassDriverCode();
            //SameTreeClassDriverCode();
            //PascalTriangleClassDriverCode();
            //BuySellStockClassDriverCode();
            //BuySellStock2ClassDriverCode();
            ValidPalindromeClassDriverCode();
            ContainerWithMostWaterDriverCode();
        }

        private static void ContainerWithMostWaterDriverCode()
        {
            ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();
            Console.WriteLine(containerWithMostWater.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 })  ); 
        }

        private static void ValidPalindromeClassDriverCode()
        {
            ValidPalindromeClass validPalindromeClass = new ValidPalindromeClass();
            validPalindromeClass.IsPalindrome("A man, a plan, a canal: Panama");
        }

        private static void BuySellStock2ClassDriverCode()
        {
            BuySellStock2Class buySellStock2Class = new BuySellStock2Class();
            buySellStock2Class.MaxProfit(new int[] { 7, 1, 5, 3, 6, 15 });
        }

        private static void BuySellStockClassDriverCode()
        {
            BuySellStockClass buySellStockClass = new BuySellStockClass();
            buySellStockClass.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
        }

        private static void PascalTriangleClassDriverCode()
        {
            PascalTriangleClass pascalTriangleClass = new PascalTriangleClass();
            pascalTriangleClass.Generate(5);
            pascalTriangleClass.GetRow(5);
        }

        private static void SameTreeClassDriverCode()
        {
            SameTreeClass sameTreeClass = new SameTreeClass();
            TreeNode tree1 = new TreeNode();
            tree1.val = 0;
            tree1.left = new TreeNode();
            tree1.left.val = 1;
            //tree1.right = new TreeNode();
            //tree1.right.val = 3;
            TreeNode tree2 = new TreeNode();
            tree2.val = 0;
            tree2.left = new TreeNode();
            tree2.left.val = 1;
            //tree2.right = new TreeNode();
            //tree2.right.val = 3;
            sameTreeClass.IsSameTree(tree1, tree2);
        }
    

        private static void MergeSortedArrayClassDriverCode()
        {
            MergeSortedArrayClass mergeSortedArrayClass = new MergeSortedArrayClass();
            mergeSortedArrayClass.Merge(new int[6] { 1, 2, 3, 0, 0, 0 }, 3, new int[3] { 2,5,6 }, 3);
        }

        private static void RemoveDuplicateFromSortedListDriverCode()
        {
            RemoveDuplicateFromSortedList removeDuplicateFromSortedList = new RemoveDuplicateFromSortedList();
            removeDuplicateFromSortedList.CreateSampleList(new Queue<int>(new int[] { 1, 1, 2, 3, 3 }), removeDuplicateFromSortedList.l);
            removeDuplicateFromSortedList.DeleteDuplicates(removeDuplicateFromSortedList.l);
        }

        private static void ClimbingStairsDriverCode()
        {
            ClimbingStairs climbingStairs = new ClimbingStairs();
            Console.WriteLine(climbingStairs.ClimbStairs(3));
        }

        private static void SquareRootDriverCode()
        {
            SquareRoot squareRoot = new SquareRoot();
            Console.WriteLine(squareRoot.Sqrt(8)); 
        }

        private static void AddBinaryDriverCode()
        {
            AddBinary addBinary = new AddBinary();
            Console.WriteLine(addBinary.AddBinaryMethod("11", "1")); 
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
            Console.WriteLine(longestCommonPrefix.FindLongestCommonPrefix(new string[] { "ab", "a" }));
        }
        static void ValidParenthesesDriverCode()
        {
            ValidParentheses validParentheses = new ValidParentheses();
            Console.WriteLine(validParentheses.CheckIfValidParentheses("["));
        }
        static void MergeSortedListsDriverCode()
        {
            MergeSortedList mergeSortedList = new MergeSortedList();
            mergeSortedList.CreateSampleList(new Queue<int>(), mergeSortedList.l1);
            mergeSortedList.CreateSampleList(new Queue<int>(), mergeSortedList.l2);
            mergeSortedList.MergeTwoLists(mergeSortedList.l1, mergeSortedList.l2);

        }
        static void RemoveDuplicatesFromSortedArrayDriverCode()
        {
            RemoveDuplicatesFromSortedArray removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();
            removeDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 1, 1, 1, 1, 1, 2 });
        }
        static void RemoveElementDriverCode()
        {
            RemoveElement removeElementDriverCode = new RemoveElement();
            removeElementDriverCode.RemoveElementMethod(new int[] { 3, 3 }, 5);
        }
        static void ImplementstrStrDriverCode()
        {
            ImplementstrStr implementstrStr = new ImplementstrStr();
            Console.WriteLine(implementstrStr.StrStr("a", "a"));
        }
        static void SearchInsertPositionDriverCode()
        {
            SearchInsertPosition searchInsertPosition = new SearchInsertPosition();
            Console.WriteLine(searchInsertPosition.SearchInsert(new int[] { 1 }, 0));
        }
        static void LengthOfLastWordClassDriverCode()
        {
            LengthOfLastWordClass lengthOfLastWordClass = new LengthOfLastWordClass();
            Console.WriteLine(lengthOfLastWordClass.LengthOfLastWord("Hello World  ")); 
        }
        static void PlusOneDriverCode()
        {
            PlusOne plusOne = new PlusOne();
            var result = plusOne.PlusOneMethod(new int[] { 9, 9 });
           result.ToList().ForEach(x => Console.WriteLine(x));
        }
        }
}
