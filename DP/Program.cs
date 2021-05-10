using DP.Aditya_Verma;
using System;
using System.Collections.Generic;

namespace DP
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClimbingStairsDriverCode();
            // LISDRiverCode();
            //MaximumSubarrayDriverCode();
            //WordBreakClassDriverCode();
            //DivisorGameClassDriverCode();
            //CostOfStairsClassDriverCode();
            //CountSortedVowelsDriverCode();
            //MaxSumArrayDriverCode();
            //LongestPalindromicSubstringDriverCode();
            //LongestCommonSubsequenceDriverCode();
            //LongestCommonSubstringDriverCode();
            //DeleteOperationsForTwoStringsDriverCode();
            //LongestPalindromicSubsequenceDriverCode();
            //PrintShortestCommonSupersequenceDriverCode();
            //MCMDriverCode();
            //PalindromicPartitioningDriverCode();
            //BooleanParanthesisDriverCode();
            CountDistinctSubsequencesDriverCode();
        }

        private static void CountDistinctSubsequencesDriverCode()
        {
            CountDistinctSubsequences countDistinctSubsequences = new CountDistinctSubsequences();
            countDistinctSubsequences.NumDistinct("babgbagh", "bag");
        }

        private static void BooleanParanthesisDriverCode()
        {
            BooleanParanthesis booleanParanthesis = new BooleanParanthesis();
            //booleanParanthesis.NumberOfWays("T^F&T");
            booleanParanthesis.NumberOfWays("T&T^F");
        }

        private static void PalindromicPartitioningDriverCode()
        {
            PalindromicPartitioning palindromicPartitioning = new PalindromicPartitioning();
            palindromicPartitioning.NumberOfCuts("aabbc");
        }

        private static void MCMDriverCode()
        {
            MCM mCM = new MCM();
            mCM.MatrixChainOrder(new int[] { 10, 30, 5, 60 });
        }

        private static void PrintShortestCommonSupersequenceDriverCode()
        {
            PrintShortestCommonSupersequence printShortestCommonSupersequence = new PrintShortestCommonSupersequence();
            printShortestCommonSupersequence.ShortestCommonSupersequence("geek", "rekefd");
        }

        private static void LongestPalindromicSubsequenceDriverCode()
        {
            LongestPalindromicSubsequence longestPalindromicSubsequence = new LongestPalindromicSubsequence();
            longestPalindromicSubsequence.LongestPalindromeSubseq("bbbab");
        }

        private static void DeleteOperationsForTwoStringsDriverCode()
        {
            DeleteOperationsForTwoStrings deleteOperationsForTwoStrings = new DeleteOperationsForTwoStrings();
            deleteOperationsForTwoStrings.MinDistance("leetcode", "etco");
        }

        private static void LongestCommonSubstringDriverCode()
        {
            LongestCommonSubstring longestCommonSubstring = new LongestCommonSubstring();
            longestCommonSubstring.LongestCommonSubstringMethod("yuytraaaa", "jkmnsyfsxtry");
        }

        private static void LongestCommonSubsequenceDriverCode()
        {
            LongestCommonSubsequence longestCommonSubsequence = new LongestCommonSubsequence();
            longestCommonSubsequence.LongestCommonSubsequenceTopDown("bbbb", "bbb");
        }

        private static void LongestPalindromicSubstringDriverCode()
        {
            LongestPalindromicSubstring longestPalindromicSubstring = new LongestPalindromicSubstring();
            longestPalindromicSubstring.LongestPalindrome("eeeee");
        }

        private static void MaxSumArrayDriverCode()
        {
            Console.WriteLine("Test 1");
            MaxSumArray.maxSubsetSum(new int[] {3,7,4,6,5 });
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Test 2");
            MaxSumArray.maxSubsetSum(new int[] { 2, 1 ,5 ,8, 4 });
            Console.WriteLine("Test 3");
            Console.WriteLine("---------------------------------");
            MaxSumArray.maxSubsetSum(new int[] { -2, 1, 3, -4, 5 });
            Console.WriteLine("Test 4");
            Console.WriteLine("---------------------------------");
            MaxSumArray.maxSubsetSum(new int[] { -2, -1, -3, -4, -5 });
            Console.WriteLine("Test 5");
            Console.WriteLine("---------------------------------");
            MaxSumArray.maxSubsetSum(new int[] { -3,5,-7,8,10 });
        }

        private static void CountSortedVowelsDriverCode()
        {
            CountSortedVowels.CountVowelStrings(3);
        }

        private static void CostOfStairsClassDriverCode()
        {
            Console.WriteLine("Test case 1 ");
            Console.WriteLine("---------------------------------");
            CostOfStairsClass.MinCostClimbingStairs(new int[] { 10, 15, 20 });
            int[] input = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                input[i] = i + 1;
            }
            Console.WriteLine("Test case 2 ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(CostOfStairsClass.MinCostClimbingStairs(input)); 
        }

        private static void DivisorGameClassDriverCode()
        {
            DivisorGameClass divisorGameClass = new DivisorGameClass();
            divisorGameClass.DivisorGame(4);
        }

        private static void WordBreakClassDriverCode()
        {
            WordBreakClass wordBreakClass = new WordBreakClass();
            wordBreakClass.WordBreak("abcdef", new List<string>() { "ab", "cd", "ef" });
        }

        private static void MaximumSubarrayDriverCode()
        {
            Console.WriteLine("Test case 1 ");
            Console.WriteLine("---------------------------------");
            MaximumSubarray.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Test case 2 ");
            Console.WriteLine("---------------------------------");
            MaximumSubarray.MaxSubArray(new int[] {1});
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Test case 3 ");
            Console.WriteLine("---------------------------------");
            MaximumSubarray.MaxSubArray(new int[] { 5, 4, -1, 7, 8 });
            Console.WriteLine("---------------------------------");
        }
        private static void LISDRiverCode()
        {
            LIS lIS = new LIS();
            int[] input = new int[1000];
            for(int i=0;i<1000;i++)
            {
                input[i] = i + 1;
            }
            input[500] = 0;
            //Console.WriteLine(lIS.CalculateLIS(input));
            Console.WriteLine(lIS.CalculateLIS(new int[] { 0}));
        }

        private static void ClimbingStairsDriverCode()
        {
            ClimbingStairs climbingStairs = new ClimbingStairs();
            climbingStairs.ClimbingStairsMethod(3);
        }
    }
}
