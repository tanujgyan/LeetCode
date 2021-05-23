using ALQ;
using System;
using System.Collections.Generic;

namespace ALQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //CombinationSumDriverCode();
            //ItemsInContainerDriverCode();
            //ReorderDataInLogFilesDriverCode();
            //HeapSortDriverCode();
            //MinimumSwapsDriverCode();
            // OnlineShoppingDriverCode();
            //RobotBoundedDriverCode();
            //CountSmallerElementsOnRightSideDriverCode();
            //NumberOfProvincesDriverCode();
            //DetectCycleInDirectedGraphDriverCode();
            //TopologicalSortingDriverCode();
         //   CourseSchedule2DriverCode();
          //  _4SumDriverCode();
           // SmallestDivisorClassDriverCode();
           // GFG_getMinimumMovesDriverCode();
            CandyClassDriverCode();
        }

        private static void CandyClassDriverCode()
        {
            CandyClass candyClass = new CandyClass();
            candyClass.Candy(new int[] { 12,4,3,11,34,34,1,67});
            //candyClass.Candy(new int[] { 1, 3, 2, 2, 1 });
        }

        private static void GFG_getMinimumMovesDriverCode()
        {
            int N = 5, K = 3, D = 2;
            int[] A = { 1, 2, 3, 4, 5 };

            Console.Write(GFG_getMinimumMoves.getMinimumMoves(N, K, D, A));
        }

        private static void SmallestDivisorClassDriverCode()
        {
            SmallestDivisorClass smallestDivisorClass = new SmallestDivisorClass();
            smallestDivisorClass.SmallestDivisor(new int[] { 962551, 933661, 905225, 923035, 990560 },10);
        }

        private static void _4SumDriverCode()
        {
            _4Sum _4Sum = new _4Sum();
            _4Sum.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0);
        }

        private static void CourseSchedule2DriverCode()
        {
            CourseSchedule2 courseSchedule2 = new CourseSchedule2();
            int[][] graph = new int[4][];
            graph[0] = new int[2];
            graph[1] = new int[2];
            graph[2] = new int[2];
            graph[3] = new int[2];
            graph[0][0] = 1;
            graph[0][ 1] = 0;
            graph[1][ 0] = 2;
            graph[1][ 1] = 0;
            graph[2][ 0] = 3;
            graph[2][ 1] = 1;
            graph[3][ 0] = 3;
            graph[3][ 1] = 2;
            courseSchedule2.FindOrder(4, graph);
        }

        private static void TopologicalSortingDriverCode()
        {
            int[][] graph = new int[4][];
            graph[0] = new int[4] { 0, 1, 1, 0 };
            graph[1] = new int[4] { 0, 0, 0, 0 };
            graph[2] = new int[4] { 0, 0, 0, 1 };
            graph[3] = new int[4] { 0, 0, 0, 0 };
            TopologicalSorting topologicalSorting = new TopologicalSorting();
            topologicalSorting.TopologicalSortingMethod(graph);
        }

        private static void DetectCycleInDirectedGraphDriverCode()
        {
            DetectCycleInDirectedGraph cycleInDirectedGraph = new DetectCycleInDirectedGraph();
            int[][] graph = new int[4][];
            graph[0] = new int[4] { 0, 1, 1, 0 };
            graph[1] = new int[4] { 0, 0, 1, 0 };
            graph[2] = new int[4] { 0, 0, 0, 1 };
            graph[3] = new int[4] { 0, 0, 0, 0 };
            cycleInDirectedGraph.DetectCycle(graph);
        }

        private static void NumberOfProvincesDriverCode()
        {
            NumberOfProvinces numberOfProvinces = new NumberOfProvinces();
            int[][] arr = new int[4][];
            arr[0] = new int[] { 1, 0, 0, 1 };
            arr[1] = new int[] { 0, 1, 1, 0 };
            arr[2] = new int[] { 0, 1, 1, 1 };
            arr[3] = new int[] { 1, 0, 1, 1 };
            numberOfProvinces.FindCircleNum(arr);
        }

        private static void CountSmallerElementsOnRightSideDriverCode()
        {
            CountSmallerElementsOnRightSide countSmallerElementsOnRightSide = new CountSmallerElementsOnRightSide();
            countSmallerElementsOnRightSide.CountSmallerOnRight(new int[] { 2, 1, 1 });
        }

        private static void RobotBoundedDriverCode()
        {
            RobotBounded robotBounded = new RobotBounded();
            robotBounded.IsRobotBounded("LLLLG");
        }

        private static void OnlineShoppingDriverCode()
        {
            OnlineShopping onlineShopping = new OnlineShopping();
            onlineShopping.NumberOfWays(new int[] { 2, 3 }, new int[] { 4 }, new int[] { 2, 3 }, new int[] { 1, 2 }, 10);
        }

        private static void MinimumSwapsDriverCode()
        {
            MinimumSwaps minimumSwaps = new MinimumSwaps();
            minimumSwaps.minimumSwaps(new int[] { 1, 3, 5, 2, 4, 6, 7 });
        }

        private static void HeapSortDriverCode()
        {
            HeapSort sort = new HeapSort();
            sort.HeapSortMethod(new int[] { 4, 3, 2, 1 });
        }

        private static void ReorderDataInLogFilesDriverCode()
        {
            ReorderDataInLogFiles reorderDataInLogFiles = new ReorderDataInLogFiles();
            reorderDataInLogFiles.ReorderLogFiles(new string[] { "6p tzwmh ige mc", "ns 566543603829", "ubd cujg j d yf", "ha6 1 938 376 5", "3yx 97 666 56 5", "d 84 34353 2249", "0 tllgmf qp znc", "s 1088746413789", "ys0 splqqxoflgx", "uhb rfrwt qzx r", "u lrvmdt ykmox", "ah4 4209164350", "rap 7729 8 125", "4 nivgc qo z i", "apx 814023338 8" });
        }

        private static void ItemsInContainerDriverCode()
        {
            ItemsInContainer itemsInContainer = new ItemsInContainer();
            itemsInContainer.NumberOfItems("|**|*|*", new List<int> { 1, 1 }, new List<int> { 5, 6 });
        }

        private static void CombinationSumDriverCode()
        {
            CombinationSum combinationSum = new CombinationSum();
            combinationSum.CombinationSumMethod(new int[] { 2, 3, 5 }, 8);
        }
    }
}
