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
            _2SumImplemntation();
            _3SumImplementation();

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
