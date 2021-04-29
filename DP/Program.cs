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
            CountSortedVowelsDriverCode();
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
