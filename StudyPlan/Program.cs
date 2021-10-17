using System;
using System.Collections.Generic;

namespace StudyPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinarySearch bs = new BinarySearch();
            //bs.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);
           //FirstBadVersionClassImplementation();
            //_2SumImplemntation();
            //_3SumImplementation();
            //_3SumClosestImplementation();
            //JumpGameImplementation();
           //MergeIntervalsImplementation();
           // HouseRobberImplementation();
            TriangleClassImplementation();
        }

        private static void TriangleClassImplementation()
        {
            TriangleClass triangleClass = new TriangleClass();
            List<IList<int>> input = new List<IList<int>>();
            input.Add(new List<int> { 2 });
            input.Add(new List<int>() { 3,4 });
            input.Add(new List<int>() { 6,5,7 });
            input.Add(new List<int>() { 4,1,8,3 });
            triangleClass.MinimumTotal(input);
        }

        private static void HouseRobberImplementation()
        {
            HouseRobber houseRobber = new HouseRobber();
            houseRobber.Rob(new int[] { 2, 1, 9, 50, 1, 50, 3, 4 });
        }

        private static void MergeIntervalsImplementation()
        {
            MergeIntervals mergeIntervals = new MergeIntervals();
            mergeIntervals.Merge(new int[][] { new int[] {1,4},
            new int[]{0,4}
            //,
            //new int[]{8,10},
            //new int[]{15,18}
            });
        }

        private static void JumpGameImplementation()
        {
            JumpGame jumpGame = new JumpGame();
            jumpGame.CanJump(new int[] { 3, 2, 1, 0, 4 });
        }

        private static void _3SumClosestImplementation()
        {
            _3SumClosest _3SumClosest = new _3SumClosest();
            _3SumClosest.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1);
        }

        private static void _3SumImplementation()
        {
            _3Sum _3Sum = new _3Sum();
            _3Sum.ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});
        }

        private static void _2SumImplemntation()
        {
            _2Sum _2Sum = new _2Sum();
            _2Sum.TwoSum(new int[] { -10,-1,-18,-19}, -19);
        }

        static void FirstBadVersionClassImplementation()
        {
            FirstBadVersionClass firstBadVersionClass = new FirstBadVersionClass();
            firstBadVersionClass.FirstBadVersion(5);
        }
    }
}
