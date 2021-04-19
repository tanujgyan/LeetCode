using LeetCode.Microsoft_Interview_Questions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //DFSGraphDriverCode();
            EmployeeImportanceClassDriverCode();
        }

        private static void EmployeeImportanceClassDriverCode()
        {
            List<Employee> employees = new List<Employee>();
            
            employees.Add(new Employee { id = 1, importance = 50, subordinates = new List<int> { 2 } });
            employees.Add(new Employee { id = 2, importance = 89, subordinates = new List<int>() {3} });
            employees.Add(new Employee { id = 3, importance = 69, subordinates = new List<int>() { 4 } });
            employees.Add(new Employee { id = 4, importance = 52, subordinates = new List<int>() { 5, 26 } });
            employees.Add(new Employee { id = 5, importance = 78, subordinates = new List<int>() { 6, 7 } });
            employees.Add(new Employee { id = 6, importance = 63, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 7, importance = 55, subordinates = new List<int>() {8 } });
            employees.Add(new Employee { id = 8, importance = 88, subordinates = new List<int>() {9,25 } });
            employees.Add(new Employee { id = 9, importance = 64, subordinates = new List<int>() {10 } });
            employees.Add(new Employee { id = 10, importance = 54, subordinates = new List<int>() { 11,19} });
            employees.Add(new Employee { id = 11, importance = 81, subordinates = new List<int>() { 12} });
            employees.Add(new Employee { id = 12, importance = 83, subordinates = new List<int>() { 13,18} });
            employees.Add(new Employee { id = 13, importance = 58, subordinates = new List<int>() { 14,15} });
            employees.Add(new Employee { id = 14, importance = 64, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 15, importance = 97, subordinates = new List<int>() { 16} });
            employees.Add(new Employee { id = 16, importance = 67, subordinates = new List<int>() { 17} });
            employees.Add(new Employee { id = 17, importance = 56, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 18, importance = 64, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 19, importance = 95, subordinates = new List<int>() { 20,23} });
            employees.Add(new Employee { id = 20, importance = 70, subordinates = new List<int>() { 21,22} });
            employees.Add(new Employee { id = 21, importance = 74, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 22, importance = 95, subordinates = new List<int>() { } });
            employees.Add(new Employee { id = 23, importance = 56, subordinates = new List<int>() {24 } });
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
            containsDuplicate2Class.ContainsNearbyDuplicate(new int[] { 1,0,1,1 }, 1);
        }

        private static void RemoveNthNodeFromLastDriverCode()
        {
            RemoveNthNodeFromLast removeNthNodeFromLast = new RemoveNthNodeFromLast();
            removeNthNodeFromLast.CreateSampleList(new Queue<int>(new[] { 1,2,3,4,5}),removeNthNodeFromLast.l1);
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
             numberOfGoodPairs.NumIdenticalPairs(new int[] { 2, 2, 1, 5, 1, 5, 5, 2, 3, 1, 1, 5, 3, 2, 3, 3, 3, 1, 3, 3, 4, 3, 1, 3, 1, 4, 5, 5, 2, 2, 1, 3, 5, 2, 2, 4, 3, 2, 5, 3, 1, 1, 3, 3, 2, 5, 2, 1, 2, 4, 3, 4, 4, 3, 2, 4, 4, 1, 3, 3, 3, 5, 5, 5, 4, 1, 1, 2, 3, 3, 2, 5, 3, 4, 5, 3, 1, 2, 5, 4, 5, 2, 3, 3, 1, 5, 2, 4, 2, 4, 4, 3, 1, 3});
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
            removeAllAdjacentDuplicatesInString2.RemoveDuplicates("pbbcggttciiippooaais", 2);
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
