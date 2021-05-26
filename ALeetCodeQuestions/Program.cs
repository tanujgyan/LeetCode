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
            //OnlineShoppingDriverCode();
            //RobotBoundedDriverCode();
            //CountSmallerElementsOnRightSideDriverCode();
            //NumberOfProvincesDriverCode();
            //DetectCycleInDirectedGraphDriverCode();
            //TopologicalSortingDriverCode();
            //   CourseSchedule2DriverCode();
            //  _4SumDriverCode();
            // SmallestDivisorClassDriverCode();
            // GFG_getMinimumMovesDriverCode();
            //CandyClassDriverCode();
            //StringReductionDriverCode();
            //RepeatedStringMatchDriverCode();
            //TopKFrequentWordsDriverCode();
            // ProductCategoriesClassDriverCode();
            //Divisibleby60PairsDriverCode();
            // FindKClosestElementsDriverCode();
            //BabyBlocksClassDriverCode();
            //PrintAllCombinationsDriverCode();
            //ShortestPathToFoodDriverCode();
            //RottingOrangesDriverCode();
            CampusBikesDriverCode();
        }

        private static void CampusBikesDriverCode()
        {
            CampusBikes campusBikes = new CampusBikes();
            campusBikes.AssignBikes(
                    new int[][] {
                    new int[]{0,0},
                    new int[]{1,1},
                    new int[]{2,0}},
                    new int[][] {
                    new int[]{1,0},
                    new int[]{2,2},
                    new int[]{2,1}});
            
        }

        private static void RottingOrangesDriverCode()
        {
            RottingOranges rottingOranges = new RottingOranges();
            int[][] grid = new int[][]
            {
                new int[]{2,1,1},
                new int[] {1,1,0},
                new int[] {0,1,1}
            };
            rottingOranges.OrangesRotting(grid);
        }

        private static void ShortestPathToFoodDriverCode()
        {
            ShortestPathToFood shortestPathToFood = new ShortestPathToFood();
            char[][] grid = new char[5][]
            {
                new char[]{'X','X','X','X','X','X','X','X'},
                new char[]{'X','*','O','O','O','#','O','X'},
                new char[]{'X','O','O','X','O','O','X','X'},
                new char[]{'X','O','O','O','O','#','O','X'},
                new char[]{'X','X','X','X','X','X','X','X'}
            };
            shortestPathToFood.ShortestPath(grid);
        }

        private static void PrintAllCombinationsDriverCode()
        {
            PrintAllCombinations printAllCombinations = new PrintAllCombinations();
            printAllCombinations.combine(new int[] { 3, 4, 5, 6, 7 }, 3);
        }

        private static void BabyBlocksClassDriverCode()
        {
            BabyBlocksClass babyBlocks = new BabyBlocksClass();
            char[][] pairs = new char[5][];
            pairs[0] = new char[2] { 'a', 'b' };
            pairs[1] = new char[2] { 'c', 'd' };
            pairs[2] = new char[2] { 'e', 'f' };
            pairs[3] = new char[2] { 'g', 'h' };
            pairs[4] = new char[2] { 'x', 'y' };
            babyBlocks.BabyBlocks(pairs, "abc");
        }

        private static void FindKClosestElementsDriverCode()
        {
            FindKClosestElements closestElements = new FindKClosestElements();
            closestElements.FindClosestElements(new int[] { 3, 5, 8, 10 }, 2, 15);
        }

        private static void Divisibleby60PairsDriverCode()
        {
            Divisibleby60Pairs divisibleby60Pairs = new Divisibleby60Pairs();
            divisibleby60Pairs.NumPairsDivisibleBy60(new int[] { 418, 204, 77, 278, 239, 457, 284, 263, 372, 279, 476, 416, 360, 18 });
        }

        private static void ProductCategoriesClassDriverCode()
        {
            ProductCategoriesClass productCategoriesClass = new ProductCategoriesClass();
            int[][] products = new int[7][];
            products[0] = new int[2] { 1, 2 };
            products[1] = new int[2] { 2, 5 };
            products[2] = new int[2] { 3, 4 };
            products[3] = new int[2] { 4, 6 };
            products[4] = new int[2] { 6, 8 };
            products[5] = new int[2] { 5, 7 };
            products[6] = new int[2] { 5, 2 };


            productCategoriesClass.CategorizeProducts(products);
        }

        private static void TopKFrequentWordsDriverCode()
        {
            TopKFrequentWords topKFrequentWords = new TopKFrequentWords();
            topKFrequentWords.TopKFrequent(new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" }, 4);
        }

        private static void RepeatedStringMatchDriverCode()
        {
            RepeatedStringMatch repeatedStringMatch = new RepeatedStringMatch();
            repeatedStringMatch.RepeatedStringMatchMethod("baa", "abaab");
        }

        private static void StringReductionDriverCode()
        {
            StringReduction stringReduction = new StringReduction();
            stringReduction.stringReduction("cbabcaa");
        }

        private static void CandyClassDriverCode()
        {
            CandyClass candyClass = new CandyClass();
            candyClass.Candy(new int[] { 12, 4, 3, 11, 34, 34, 1, 67 });
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
            smallestDivisorClass.SmallestDivisor(new int[] { 962551, 933661, 905225, 923035, 990560 }, 10);
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
            graph[0][1] = 0;
            graph[1][0] = 2;
            graph[1][1] = 0;
            graph[2][0] = 3;
            graph[2][1] = 1;
            graph[3][0] = 3;
            graph[3][1] = 2;
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
            onlineShopping.NumberOfWays(new int[] { 2, 3, 4 }, new int[] { 4, 5, 6 }, new int[] { 2, 3, 7 }, new int[] { 1, 2, 8 }, 10);
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
