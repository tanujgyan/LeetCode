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
            ItemsInContainerDriverCode();
            ReorderDataInLogFilesDriverCode();
        }

        private static void ReorderDataInLogFilesDriverCode()
        {
            ReorderDataInLogFiles reorderDataInLogFiles = new ReorderDataInLogFiles();
            reorderDataInLogFiles.ReorderLogFiles(new string[] {"6p tzwmh ige mc", "ns 566543603829", "ubd cujg j d yf", "ha6 1 938 376 5", "3yx 97 666 56 5", "d 84 34353 2249", "0 tllgmf qp znc", "s 1088746413789", "ys0 splqqxoflgx", "uhb rfrwt qzx r", "u lrvmdt ykmox", "ah4 4209164350", "rap 7729 8 125", "4 nivgc qo z i", "apx 814023338 8"});
        }

        private static void ItemsInContainerDriverCode()
        {
            ItemsInContainer itemsInContainer = new ItemsInContainer();
            itemsInContainer.NumberOfItems("|**|*|*", new List<int> { 1, 1 }, new List<int> { 5, 6 });
        }

        private static void CombinationSumDriverCode()
        {
            CombinationSum combinationSum = new CombinationSum();
            combinationSum.CombinationSumMethod(new int[] { 2, 3,5}, 8);
        }
    }
}
