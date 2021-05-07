using LeetCode.Amazon_Interview_Questions;
using LeetCode.Microsoft_Interview_Questions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using LeetCode.Recursion_Problems;
using LeetCode.DFS_Questions;
using LeetCode.Backtracking;
using LeetCode.Hacker_Rank;
using LeetCode.Code_Line;

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
            //ValidPalindromeClassDriverCode();
            // ContainerWithMostWaterDriverCode();
            //TwoSumArraySortedInputDriverCode();
            //ExcelSheetColumnTitleDriverCode();
            //ExcelSheetColumnNumberDriverCode();
            //MajorityElementClassDriverCode();
            //RemoveAllAdjacentDuplicatesInString2DriverCode();
            // ContainsDuplicateClassDriverCode();
            //MinDeletionUniqueStringDriverCode();
            //MinAdjacentSwapsToMakePalindromeDriverCode();
            //NumberOfGoodPairsDriverCode();
            // LongestSubstringWithoutRepeatingCharactersDriverCode();
            //GridTravellerProblemDriverCode();
            //RemoveNthNodeFromLastDriverCode();
            // ContainsDuplicate2ClassDriverCode();
            //LetterCombinationsOfPhoneNumberDriverCode();
            // DFSGraphDriverCode();
            //EmployeeImportanceClassDriverCode();
            //MinStackDriverCode();
            //ThirdMaxClassDriverCode();
            //CanPlaceFlowersClassDriverCode();
            // MountainArrayClassDriverCode();
            // X_Of_a_Kind_In_Deck_DriverCode();
            //MostCommonWordDriverCode();
            //CoinChangeClassDriverCode();
            //HowSumDriverCode();
            // FirstUniqueCharacterInStringDriverCode();
            //SingleNumberClassDriverCode();
            //PowerOfTwoDriverCode();
            //RobotReturnToOriginDriverCode();
            // MissingNumberClassDriverCode();
            //PathSumsClassDriverCode();
            //RottingOrangesDriverCode();
            // PartitionLabelDriverCode();
            // LongestCommonPrefixDriverCode();
            //WordSearchClassDriverCode();
            //PathSum2ClassDriverCode();
            //ReorganizeStringClassDriverCode();
            //GroupAnagramsClassDriverCode();
            //ReverseVowelsClassDriverCode();
            // IntersectionOfTwoLinkedListsDriverCode();
            //LetterCombinationOfPhoneNumberWithDFSDriverCode();
            // KClosestPointClassDriverCode();
            //SortByParityClassDriverCode();
            // LastStoneWeightClassDriverCode();
            //StringCompressionDriverCode();
            //NumberOfIslandsDriverCode();
            //NumberOfEnclavesDriverCode();
            //SorroundedRegionsDriverCode();
            //PairWithGivenProductClassDriverCode();
            //CountMatchesOfATournamentDriverCode();
            //MaximumProductOfThreeNumbersDriverCode();
            //BalancedBracketsDriverCode();
            // LargestRectangleClassDriverCode();
            //MakingAnagramsClassDriverCode();
            // AlternatingCharcatersClassDriverCode();
            //CamelCaseMatchingDriverCode();
            //NumberOfCamelCaseDriverCode();
            //TwoCharacterDriverCode();
            //SherlockAndValidStringsDriverCode();
            //RotateImageDriverCode();
            //DebtCoverDriverCode();
            //ReverseLinkedListDriverCode();
            // PalindromicLinkedListDriverCode();
            //RemoveFromLinkedListDriverCode();
            //GroupingDishesDriverCode();
            //ContainCloseNumsClassDriverCode();
            //PossibleSumsClassDriverCode();
            // CountCloudsClassDriverCode();
            //FirstMissingPositiveClassDriverCode();
            // TargetSumDriverCode();
            //PartitionSumDriverCode();
            //CopyListWithRandomPointerDriverCode();
            //LevelOrderTraversalOfBTDriverCode();
            //ValidBSTDriverCode();
            ReverseWordsClassDriverCode();
            #region Recursion Problems
            //FibonnaciSeriesDriverCode();
            //StrCpyDriverCode();
            //FirstUpperCaseCharacterDriverCode();
            //LengthOfStringUsingRecursionDriverCode();
            //CountConsonantsClassDriverCode();
            // CombinationInAstringOfDigitsDriverCode();
            #endregion
        }

        private static void ReverseWordsClassDriverCode()
        {
            ReverseWordsClass reverseWordsClass = new ReverseWordsClass();
            Console.WriteLine(reverseWordsClass.ReverseWords("Alice does not even like bob")); 
        }

        private static void ValidBSTDriverCode()
        {
            ValidBST validBST = new ValidBST();
            TreeNode treeNode = new TreeNode();
            treeNode.val = -2147483648;
            //treeNode.left = new TreeNode(-57);
            treeNode.right = new TreeNode(2147483647);
            //treeNode.left.left = new TreeNode(0);
            //treeNode.left.right = new TreeNode(58);
            ////treeNode.right.left = new TreeNode(4);
            ////treeNode.right.right = new TreeNode(6);
            ////treeNode.left.left.left = new TreeNode(4);
            ////treeNode.right.right.right = new TreeNode(1);
            //treeNode.left.right.left = new TreeNode(31);
            validBST.IsValidBST(treeNode);
        }

        private static void LevelOrderTraversalOfBTDriverCode()
        {
            LevelOrderTraversalOfBT levelOrderTraversalOfBT = new LevelOrderTraversalOfBT();
            TreeNode treeNode = new TreeNode();
            treeNode.val = 3;
            treeNode.left = new TreeNode(6);
            treeNode.right = new TreeNode(9);
            treeNode.left.left = new TreeNode(5);
            treeNode.left.right = new TreeNode(8);
            treeNode.right.left = new TreeNode(10);
            treeNode.right.right = new TreeNode(11);
            treeNode.left.left.left = new TreeNode(21);
            treeNode.right.right.right = new TreeNode(22);
            levelOrderTraversalOfBT.LevelOrder(treeNode);

        }

        private static void CopyListWithRandomPointerDriverCode()
        {
            CopyListWithRandomPointer copyListWithRandomPointer = new CopyListWithRandomPointer();
            Node list = new Node(1);
            list.next = new Node(2);
            list.random = list.next;
            list.next.next = new Node(3);
            list.next.next.next = new Node(4);
            list.random.random = list.next.next;
            copyListWithRandomPointer.CopyRandomList(list);
        }

        private static void PartitionSumDriverCode()
        {
            PartitionSum partitionSum = new PartitionSum();
            partitionSum.CanPartition(new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 99, 97 });
            //partitionSum.CanPartition(new int[] { 14,9,8,4,3,2 });
            //partitionSum.CanPartition(new int[] { 1,5,11,5 });
        }

        private static void TargetSumDriverCode()
        {
            TargetSum targetSum = new TargetSum();
            targetSum.TargetSumTopDown(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1 }, 1);
        }

        private static void FirstMissingPositiveClassDriverCode()
        {
            FirstMissingPositiveClass firstMissingPositiveClass = new FirstMissingPositiveClass();
            firstMissingPositiveClass.FirstMissingPositive(new int[] { 1 });
        }

        private static void CountCloudsClassDriverCode()
        {
            CountCloudsClass countCloudsClass = new CountCloudsClass();
            char[][] skyMap = new char[4][]
            {
                new char[]{'0', '1', '1', '0', '1'},
                 new char[] { '0', '1', '1', '1', '1' },
                 new char[] { '0', '0', '0', '0', '1' },
                  new char[] { '1', '0', '0', '1', '1' }
            };
            //countCloudsClass.countClouds(skyMap);
            countCloudsClass.countClouds(new char[0][]);
        }

        private static void PossibleSumsClassDriverCode()
        {
            PossibleSumsClass possibleSumsClass = new PossibleSumsClass();
            possibleSumsClass.possibleSums(new int[] { 1,2}, new int[] { 50000,2});
        }

        private static void ContainCloseNumsClassDriverCode()
        {
            ContainCloseNumsClass containCloseNumsClass = new ContainCloseNumsClass();
            containCloseNumsClass.containsCloseNums(new int[] { 0, 1, 2, 3, 5, 2 }, 3);
        }

        private static void GroupingDishesDriverCode()
        {
            string[][] dishes = new string[4][];
            dishes[0] = new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" };
            dishes[1] = new string[] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" };
            dishes[2] = new string[] { "Quesadilla", "Chicken", "Cheese", "Sauce" };
            dishes[3] = new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" };
            GroupingDishes groupingDishes = new GroupingDishes();
            groupingDishes.groupingDishes(dishes);
        }

        private static void RemoveFromLinkedListDriverCode()
        {
            RemoveFromLinkedList removeFromLinkedList = new RemoveFromLinkedList();
            ListNode list =
                new ListNode(7,
                new ListNode(7,
                new ListNode(7,
                new ListNode(7, null))));
            removeFromLinkedList.RemoveElements(list, 7);
        }

        private static void PalindromicLinkedListDriverCode()
        {
            PalindromicLinkedList palindromicLinkedList = new PalindromicLinkedList(new ReverseLinkedList());
            ListNode list =
                new ListNode(7,
                new ListNode(7,
                new ListNode(7,
                new ListNode(7, null))));
            palindromicLinkedList.IsPalindrome(list);
        }

        private static void ReverseLinkedListDriverCode()
        {
            ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
            ListNode list = 
                new ListNode(1,
                new ListNode(2,
                new ListNode(3,
                new ListNode(4, null))));
            reverseLinkedList.ReverseLL(list);
        }

        private static void DebtCoverDriverCode()
        {
            DebtCover debtCover = new DebtCover();
            debtCover.DebtCoverMethod(50, 10, new float[] { 2, 2, 5 }, new float[] { 200, 100, 150 });
        }

        private static void RotateImageDriverCode()
        {
            RotateImage rotateImage = new RotateImage();
            rotateImage.rotateImage(new int[3][]
            {
                new int[]{1,2,3},
                new int[]{4,5,6},
                new int[]{7,8,9}
            });
        }

        private static void SherlockAndValidStringsDriverCode()
        {
            Console.WriteLine(SherlockAndValidStrings.isValid("abcdefghhgfedecba")); 
        }

        private static void TwoCharacterDriverCode()
        {
            TwoCharacter.alternate("beabeefeab");
        }

        private static void NumberOfCamelCaseDriverCode()
        {
            NumberOfCamelCase.camelcase("saveChangesInTheEditor");
        }

        private static void CamelCaseMatchingDriverCode()
        {
            CamelCaseMatching camelCaseMatching = new CamelCaseMatching();
            camelCaseMatching.CamelMatch(new string[] { "FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack" }, "FoBa");
        }

        private static void AlternatingCharcatersClassDriverCode()
        {
            AlternatingCharcatersClass.alternatingCharacters("AAABBB");
        }

        private static void MakingAnagramsClassDriverCode()
        {
            MakingAnagramsClass.makeAnagram("abccc", "dec");
        }

        private static void LargestRectangleClassDriverCode()
        {
            LargestRectangleClass largestRectangleClass = new LargestRectangleClass();
            largestRectangleClass.LargestRectangleAreaStackAlgorithm(new int[] {2,4});
        }

        private static void BalancedBracketsDriverCode()
        {
            Console.WriteLine(BalancedBrackets.isBalanced("]"));
        }

        private static void MaximumProductOfThreeNumbersDriverCode()
        {
            MaximumProductOfThreeNumbers maximumProductOfThreeNumbers = new MaximumProductOfThreeNumbers();
            maximumProductOfThreeNumbers.MaximumProduct(new int[] { -1, -2, -3,-4});
        }

        private static void CountMatchesOfATournamentDriverCode()
        {
            CountMatchesOfATournament countMatchesOfATournament = new CountMatchesOfATournament();
            Console.WriteLine(countMatchesOfATournament.NumberOfMatches(14)); 
        }

        private static void PairWithGivenProductClassDriverCode()
        {
            PairWithGivenProductClass pairWithGivenProductClass = new PairWithGivenProductClass();
            Console.WriteLine(pairWithGivenProductClass.PairWithGivenProduct(new int[] { -10, 20, 9, 40 },-400)); 
        }

        private static void SorroundedRegionsDriverCode()
        {
            SorroundedRegions sorrounded = new SorroundedRegions();
            char[][] grid = new char[3][];
            //grid[0] = new char[] { 'X', 'X', 'X', 'X' };
            //grid[1] = new char[] { 'X', 'O', 'O', 'X' };
            //grid[2] = new char[] { 'X', 'X', 'O', 'X'};
            //grid[3] = new char[] { 'X', 'O', 'X', 'X'};
            grid[0] = new char[] { 'O', 'O', 'O'};
            grid[1] = new char[] { 'O', 'O', 'O' };
            grid[2] = new char[] { 'O', 'O', 'O' };
          

            sorrounded.Solve(grid);
        }

        private static void NumberOfEnclavesDriverCode()
        {
            NumberOfEnclaves numberOfEnclaves = new NumberOfEnclaves();
            int[][] grid = new int[10][] {
                new int[]{0,0,0,1,1,1,0,1,0,0},
                new int[]{1,1,0,0,0,1,0,1,1,1},
                new int[]{0,0,0,1,1,1,0,1,0,0},
                new int[]{0,1,1,0,0,0,1,0,1,0},
                new int[]{0,1,1,1,1,1,0,0,1,0},
                new int[]{0,0,1,0,1,1,1,1,0,1},
                new int[]{0,1,1,0,0,0,1,1,1,1},
                new int[]{0,0,1,0,0,1,0,1,0,1},
                new int[]{1,0,1,0,1,1,0,0,0,0},
                new int[]{0,0,0,0,1,1,0,0,0,1}
            };

            numberOfEnclaves.NumEnclaves(grid);
        }

        private static void NumberOfIslandsDriverCode()
        {
            NumberOfIslands numberOfIslands = new NumberOfIslands();
            char[][] grid = new char[4][];
            grid[0] = new char[] { '1', '1', '1', '1', '0' };
            grid[1] = new char[] { '1', '1', '0', '1', '0' };
            grid[2] = new char[] { '1', '1', '0', '0', '0' };
            grid[3] = new char[] { '0', '0', '0', '0', '0' };
            numberOfIslands.NumIslands(grid);
        }

        private static void StringCompressionDriverCode()
        {
            StringCompression stringCompression = new StringCompression();
            stringCompression.Compress(new char[] { 'a', 'a', 'b', 'b', 'b', 'a', 'a' });
        }

        private static void LastStoneWeightClassDriverCode()
        {
            LastStoneWeightClass lastStoneWeightClass = new LastStoneWeightClass();
            lastStoneWeightClass.LastStoneWeight(new int[] { 2, 2 });
        }

        private static void SortByParityClassDriverCode()
        {
            SortByParityClass sortByParityClass = new SortByParityClass();
            sortByParityClass.SortArrayByParity(new int[] { 1, 2, 3, 4 });
        }

        private static void KClosestPointClassDriverCode()
        {
            KClosestPointClass kClosestPointClass = new KClosestPointClass();
            var data = new int[2][];
            data[0] = new int[] { 1, 3 };
            data[1] = new int[] { -2, 2 };

            kClosestPointClass.KClosest(data, 1);
        }

        private static void LetterCombinationOfPhoneNumberWithDFSDriverCode()
        {
            LetterCombinationOfPhoneNumberWithDFS letterCombinationOfPhoneNumberWithDFS = new LetterCombinationOfPhoneNumberWithDFS();
            letterCombinationOfPhoneNumberWithDFS.LetterCombinations("234");
        }

        private static void IntersectionOfTwoLinkedListsDriverCode()
        {
            IntersectionOfTwoLinkedLists intersectionOfTwoLinkedLists = new IntersectionOfTwoLinkedLists();
            intersectionOfTwoLinkedLists.CreateSampleList(new Queue<int>(new int[] { 4, 1, 8, 4, 5 }), intersectionOfTwoLinkedLists.nodeA);
            intersectionOfTwoLinkedLists.CreateSampleList(new Queue<int>(new int[] { 5, 6, 1, 8, 4, 5 }), intersectionOfTwoLinkedLists.nodeB);
            intersectionOfTwoLinkedLists.GetIntersectionNode(intersectionOfTwoLinkedLists.nodeA, intersectionOfTwoLinkedLists.nodeB);
        }

        private static void ReverseVowelsClassDriverCode()
        {
            ReverseVowelsClass reverseVowelsClass = new ReverseVowelsClass();
            reverseVowelsClass.ReverseVowels("race car");
        }

        private static void GroupAnagramsClassDriverCode()
        {
            GroupAnagramsClass groupAnagramsClass = new GroupAnagramsClass();
            groupAnagramsClass.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        }

        private static void ReorganizeStringClassDriverCode()
        {
            ReorganizeStringClass reorganizeStringClass = new ReorganizeStringClass();
            reorganizeStringClass.ReorganizeString("aaabbccccccc");
        }

        private static void PathSum2ClassDriverCode()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            PathSum2Class pathSum2Class = new PathSum2Class();
            TreeNode binaryTree = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(2), new TreeNode(2))), new TreeNode(8, new TreeNode(9), new TreeNode(4, null, new TreeNode(1))));
            pathSum2Class.PathSum(binaryTree, 22);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private static void CombinationInAstringOfDigitsDriverCode()
        {
            CombinationInAstringOfDigits combinationInAstringOfDigits = new CombinationInAstringOfDigits();

            char[] input = "1234".ToCharArray();
            char[] output = new char[100];

            combinationInAstringOfDigits.printCombinations(input, 0, output, 0);
        }

        private static void CountConsonantsClassDriverCode()
        {
            CountConsonantsClass countconstants = new CountConsonantsClass();
            Console.WriteLine(countconstants.CountConsonants("geeks for geeks"));
        }

        private static void LengthOfStringUsingRecursionDriverCode()
        {
            LengthOfStringUsingRecursion lengthOfStringUsingRecursion = new LengthOfStringUsingRecursion();
            Console.WriteLine(lengthOfStringUsingRecursion.stringLength("geeks"));
        }

        private static void FirstUpperCaseCharacterDriverCode()
        {
            FirstUpperCaseCharacter firstUpperCaseCharacter = new FirstUpperCaseCharacter();
            Console.WriteLine(firstUpperCaseCharacter.FirstUpperCaseCharacterMethod("geeksforgeeks"));
        }

        private static void StrCpyDriverCode()
        {
            StrCpy strCpy = new StrCpy();
            Console.WriteLine(strCpy.strCpyMethod("hello", "g", 0));
        }

        #region Recursion Problems Calls
        private static void FibonnaciSeriesDriverCode()
        {
            FibonnaciSeries fibonnaciSeriesDriverCode = new FibonnaciSeries();
            Console.WriteLine(fibonnaciSeriesDriverCode.CalculateFibonnaci(1234));
        }


        #endregion
        private static void WordSearchClassDriverCode()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            WordSearchClass wordSearch = new WordSearchClass();
            var data = new char[3][];
            data[0] = new char[] { 'A', 'B', 'C', 'E' };
            data[1] = new char[] { 'S', 'F', 'C', 'S' };
            data[2] = new char[] { 'A', 'D', 'E', 'E' };
            wordSearch.Exist(data, "ADX");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private static void LongestCommonPrefixDriverCode()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            LeetCode.Amazon_Interview_Questions.LongestCommonPrefix longestCommonPrefix = new LeetCode.Amazon_Interview_Questions.LongestCommonPrefix();
            Console.WriteLine(longestCommonPrefix.LongestCommonPrefixMethod(new string[] { "a" }));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private static void PartitionLabelDriverCode()
        {
            PartitionLabel partitionLabel = new PartitionLabel();
            partitionLabel.PartitionLabels("abacbded");
        }

        private static void RottingOrangesDriverCode()
        {
            RottingOranges rottingOranges = new RottingOranges();
            var data = new int[3][];
            data[0] = new int[] { 2, 1, 1 };
            data[1] = new int[] { 1, 1, 0 };
            data[2] = new int[] { 0, 1, 1 };
            Console.WriteLine(rottingOranges.OrangesRotting(data));
        }

        private static void PathSumsClassDriverCode()
        {
            PathSumsClass pathSumsClass = new PathSumsClass();
            TreeNode binaryTree = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))), new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1))));
            Console.WriteLine(pathSumsClass.HasPathSum2(binaryTree, 22));

        }

        private static void MissingNumberClassDriverCode()
        {
            MissingNumberClass missingNumberClass = new MissingNumberClass();
            Console.WriteLine(missingNumberClass.MissingNumber(new int[] { 0, 1 }));
        }

        private static void RobotReturnToOriginDriverCode()
        {
            RobotReturnToOrigin robotReturnToOrigin = new RobotReturnToOrigin();
            robotReturnToOrigin.JudgeCircle("UD");
        }

        private static void PowerOfTwoDriverCode()
        {
            PowerOfTwo powerOfTwo = new PowerOfTwo();
            Console.WriteLine(powerOfTwo.IsPowerOfTwo(6));
        }

        private static void SingleNumberClassDriverCode()
        {
            SingleNumberClass singleNumberClass = new SingleNumberClass();
            Console.WriteLine(singleNumberClass.SingleNumberUsingXOR(new int[] { 1, 1, 2, 2, 3 }));
        }

        private static void FirstUniqueCharacterInStringDriverCode()
        {
            FirstUniqueCharacterInString firstUniqueCharacterInString = new FirstUniqueCharacterInString();
            Console.WriteLine(firstUniqueCharacterInString.FirstUniqChar("aabbc"));
        }

        private static void HowSumDriverCode()
        {
            HowSum howSum = new HowSum();
            // var r= howSum.HowSumMethodOptimal(new int[] { 83, 186, 408, 419  }, 6249);
            //var r = howSum.coinChange(new int[] { 1,2 }, 3);
            var r = howSum.minCoins(new int[] { 5, 3, 4, 7 }, 7);
            //var r = howSum.HowSumMethodOptimal(new int[] { 5, 3, 4, 7 }, 7);
            Console.WriteLine(r);
            //Console.WriteLine(r.Sum());
        }

        private static void CoinChangeClassDriverCode()
        {
            CoinChangeClass coinChangeClass = new CoinChangeClass();
            //coinChangeClass.CoinChange(new int[] { 186,419,83,408}, 6249);
            //var r= coinChangeClass.CoinChange(new int[] { 2,5}, 11);
            //Console.WriteLine(r);

        }

        private static void MostCommonWordDriverCode()
        {
            MostCommonWordClass mostCommonWord = new MostCommonWordClass();
            // mostCommonWord.MostCommonWord("ball.toy ,        roy roy!", new string[] { " " });
            //mostCommonWord.MostCommonWordAttempt2("ball.toy ,        roy roy!", new string[] { " " });
            mostCommonWord.MostCommonWordAttempt2("a, a, a, a, b,b,b,c, c", new string[] { "a" });
        }

        private static void X_Of_a_Kind_In_Deck_DriverCode()
        {
            X_Of_a_Kind_In_Deck x_Of_A_Kind_In_Deck = new X_Of_a_Kind_In_Deck();
            //x_Of_A_Kind_In_Deck.HasGroupsSizeX(new int[] { 1, 1, 2, 2, 2, 2 }); //positive test case
            //x_Of_A_Kind_In_Deck.HasGroupsSizeX(new int[] { 1, 1, 2, 2, 2 }); //negative test case
            //x_Of_A_Kind_In_Deck.HasGroupsSizeX(new int[] { 1, 2, 2, 2, 2 }); //negative test case
            x_Of_A_Kind_In_Deck.HasGroupsSizeX(new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 });//positive test case
        }

        private static void MountainArrayClassDriverCode()
        {
            MountainArrayClass mountainArrayClass = new MountainArrayClass();
            mountainArrayClass.ValidMountainArray(new int[] { 5, 6, 7, 8, 6 });
        }

        private static void CanPlaceFlowersClassDriverCode()
        {
            CanPlaceFlowersClass canPlaceFlowersClass = new CanPlaceFlowersClass();
            canPlaceFlowersClass.CanPlaceFlowers(new int[] { 1 }, 0);
        }

        private static void ThirdMaxClassDriverCode()
        {
            ThirdMaxClass thirdMaxClass = new ThirdMaxClass();
            thirdMaxClass.ThirdMax(new int[] { 1, 2, 2, 5, 3, 5 });
        }

        private static void MinStackDriverCode()
        {
            MinStack obj = new MinStack();
            obj.Push(-2);
            obj.Push(0);
            obj.Push(-3);
            int param_1 = obj.GetMin();
            obj.Pop();
            int param_3 = obj.Top();
            int param_4 = obj.GetMin();
        }

        private static void EmployeeImportanceClassDriverCode()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { id = 1, importance = 50, subordinates = new List<int> { 2 } });
            employees.Add(new Employee { id = 2, importance = 89, subordinates = new List<int>() { 3 } });
            employees.Add(new Employee { id = 3, importance = 69, subordinates = new List<int>() { 4 } });
            employees.Add(new Employee { id = 4, importance = 52, subordinates = new List<int>() { 5, 26 } });
            employees.Add(new Employee { id = 5, importance = 78, subordinates = new List<int>() { 6, 7 } });
            employees.Add(new Employee { id = 6, importance = 63, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 7, importance = 55, subordinates = new List<int>() { 8 } });
            employees.Add(new Employee { id = 8, importance = 88, subordinates = new List<int>() { 9, 25 } });
            employees.Add(new Employee { id = 9, importance = 64, subordinates = new List<int>() { 10 } });
            employees.Add(new Employee { id = 10, importance = 54, subordinates = new List<int>() { 11, 19 } });
            employees.Add(new Employee { id = 11, importance = 81, subordinates = new List<int>() { 12 } });
            employees.Add(new Employee { id = 12, importance = 83, subordinates = new List<int>() { 13, 18 } });
            employees.Add(new Employee { id = 13, importance = 58, subordinates = new List<int>() { 14, 15 } });
            employees.Add(new Employee { id = 14, importance = 64, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 15, importance = 97, subordinates = new List<int>() { 16 } });
            employees.Add(new Employee { id = 16, importance = 67, subordinates = new List<int>() { 17 } });
            employees.Add(new Employee { id = 17, importance = 56, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 18, importance = 64, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 19, importance = 95, subordinates = new List<int>() { 20, 23 } });
            employees.Add(new Employee { id = 20, importance = 70, subordinates = new List<int>() { 21, 22 } });
            employees.Add(new Employee { id = 21, importance = 74, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 22, importance = 95, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 23, importance = 56, subordinates = new List<int>() { 24 } });
            employees.Add(new Employee { id = 24, importance = 100, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 25, importance = 69, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 26, importance = 98, subordinates = new List<int>() { } });
            EmployeeImportanceClass employeeImportanceClass = new EmployeeImportanceClass();
            //employeeImportanceClass.AddToStack(employees, 1);
            employeeImportanceClass.GetImportance(employees, 1);
        }

        private static void DFSGraphDriverCode()
        {
            DFSGraph g = new DFSGraph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.WriteLine(
                "Following is Depth First Traversal "
                + "(starting from vertex 2)");

            g.DFS(2);
            Console.ReadKey();
        }

        private static void LetterCombinationsOfPhoneNumberDriverCode()
        {
            LetterCombinationsOfPhoneNumber letterCombinationsOfPhoneNumber = new LetterCombinationsOfPhoneNumber();
            letterCombinationsOfPhoneNumber.LetterCombinations("423");
        }

        private static void ContainsDuplicate2ClassDriverCode()
        {
            ContainsDuplicate2Class containsDuplicate2Class = new ContainsDuplicate2Class();
            containsDuplicate2Class.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);
        }

        private static void RemoveNthNodeFromLastDriverCode()
        {
            RemoveNthNodeFromLast removeNthNodeFromLast = new RemoveNthNodeFromLast();
            removeNthNodeFromLast.CreateSampleList(new Queue<int>(new[] { 1, 2, 3, 4, 5 }), removeNthNodeFromLast.l1);
            removeNthNodeFromLast.RemoveNthFromEnd(removeNthNodeFromLast.l1, 2);
        }

        private static void GridTravellerProblemDriverCode()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            GridTravellerProblem gridTravellerProblem = new GridTravellerProblem();
            Console.WriteLine(gridTravellerProblem.UniquePaths(3, 7));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private static void LongestSubstringWithoutRepeatingCharactersDriverCode()
        {
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();
            longestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abcdcefgh");
        }

        private static void NumberOfGoodPairsDriverCode()
        {
            NumberOfGoodPairs numberOfGoodPairs = new NumberOfGoodPairs();
            numberOfGoodPairs.NumIdenticalPairs(new int[] { 2, 2, 1, 5, 1, 5, 5, 2, 3, 1, 1, 5, 3, 2, 3, 3, 3, 1, 3, 3, 4, 3, 1, 3, 1, 4, 5, 5, 2, 2, 1, 3, 5, 2, 2, 4, 3, 2, 5, 3, 1, 1, 3, 3, 2, 5, 2, 1, 2, 4, 3, 4, 4, 3, 2, 4, 4, 1, 3, 3, 3, 5, 5, 5, 4, 1, 1, 2, 3, 3, 2, 5, 3, 4, 5, 3, 1, 2, 5, 4, 5, 2, 3, 3, 1, 5, 2, 4, 2, 4, 4, 3, 1, 3 });
            // numberOfGoodPairs.NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 });
        }

        private static void MinAdjacentSwapsToMakePalindromeDriverCode()
        {
            MinAdjacentSwapsToMakePalindrome minAdjacentSwapsToMakePalindrome = new MinAdjacentSwapsToMakePalindrome();
            minAdjacentSwapsToMakePalindrome.AdjacentSwaps("asflkj");
        }

        private static void MinDeletionUniqueStringDriverCode()
        {
            MinDeletionUniqueString minDeletionUniqueString = new MinDeletionUniqueString();
            minDeletionUniqueString.MinDeletions("hogdheejnglfmaidocafjngkf");
        }

        private static void ContainsDuplicateClassDriverCode()
        {
            ContainsDuplicateClass containsDuplicateClass = new ContainsDuplicateClass();
            containsDuplicateClass.ContainsDuplicate(new int[] { 1, 2, 3, 1 });
        }

        private static void RemoveAllAdjacentDuplicatesInString2DriverCode()
        {
            RemoveAllAdjacentDuplicatesInString2 removeAllAdjacentDuplicatesInString2 = new RemoveAllAdjacentDuplicatesInString2();
            removeAllAdjacentDuplicatesInString2.RemoveDuplicates("aa", 2);
        }

        private static void MajorityElementClassDriverCode()
        {
            MajorityElementClass majorityElementClass = new MajorityElementClass();
            Console.WriteLine(majorityElementClass.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }

        private static void ExcelSheetColumnNumberDriverCode()
        {
            ExcelSheetColumnNumber excelSheetColumnNumber = new ExcelSheetColumnNumber();
            excelSheetColumnNumber.TitleToNumber("ZY");
        }

        private static void ExcelSheetColumnTitleDriverCode()
        {
            ExcelSheetColumnTitle excelSheetColumnTitle = new ExcelSheetColumnTitle();
            Console.WriteLine(excelSheetColumnTitle.ConvertToTitle(586));
        }

        private static void TwoSumArraySortedInputDriverCode()
        {
            TwoSumArraySortedInput twoSumArraySortedInput = new TwoSumArraySortedInput();
            Console.WriteLine(twoSumArraySortedInput.TwoSum(new int[] { 2, 7, 11, 15 }, 9));
        }

        private static void ContainerWithMostWaterDriverCode()
        {
            ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();
            Console.WriteLine(containerWithMostWater.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
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
            mergeSortedArrayClass.Merge(new int[6] { 1, 2, 3, 0, 0, 0 }, 3, new int[3] { 2, 5, 6 }, 3);
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
            int[] nums = new int[] { 3, 3, 6 };
            int target = 0;
            var result = twoSum.TwoSumCalculator(nums, target);
            var dictResult = twoSum.TwoSumCalculatorUsingDictionary(nums, 3);
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
            // mergeSortedList.CreateSampleList(new Queue<int>(new int[] { 5 })  , mergeSortedList.l1);
            //mergeSortedList.CreateSampleList(new Queue<int>(new int[] { 1,3,4}) , mergeSortedList.l2);
            //mergeSortedList.MergeTwoLists(mergeSortedList.l1, mergeSortedList.l2);
            //mergeSortedList.l1 =
            //     new ListNode (4, null);
            //mergeSortedList.l2 =
            //     new ListNode(1, null);
            mergeSortedList.l2 =
               new ListNode(1,
               new ListNode(3,
               new ListNode(4)));
            mergeSortedList.l1 =
            new ListNode(1,
            new ListNode(2,
            new ListNode(4)));
            mergeSortedList.MergeTwoListsWithoutQueue(mergeSortedList.l1, mergeSortedList.l2);

        }
        static void RemoveDuplicatesFromSortedArrayDriverCode()
        {
            RemoveDuplicatesFromSortedArray removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();
            removeDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 1, 1, 1, 1, 1, 2 });
        }
        static void RemoveElementDriverCode()
        {
            RemoveElement removeElementDriverCode = new RemoveElement();
            removeElementDriverCode.RemoveElementMethod(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
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
