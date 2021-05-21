using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/combination-sum/
/// </summary>
namespace ALQ
{
    class CombinationSum
    {
        List<string> result = new List<string>();
        List<IList<int>> retVal = new List<IList<int>>();
        public List<IList<int>> CombinationSumMethod(int[] candidates, int target)
        {
            CombinationSumMethodHelper(candidates, target, 0, new List<int>());
            foreach(var s in result)
            {
                retVal.Add(ConvertStringAndStoreToResult(s));
            }
            return retVal;
        }
        private string AppendListItemsToString(List<int> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var l in list)
            {
                sb.Append(l);
                sb.Append("_");
            }
            return sb.ToString();
        }
        private List<int> ConvertStringAndStoreToResult(string s)
        {
            var a = s.Remove(s.Length-1).Split("_");
            List<int> l = new List<int>();
            foreach(var e in a)
            {
                l.Add(Convert.ToInt32(e));
            }
            return l;
        }
        private int CombinationSumMethodHelper(int[] candidates, int target, int currentSum, List<int> list)
        {
            if (currentSum == target)
            {
                var l = list.OrderBy(x => x).ToList();
                var s = AppendListItemsToString(l);
                if(!result.Contains(s))
                {
                    result.Add(s);
                }
                return 0;
            }
            if (currentSum > target)
            {

                return currentSum - list.LastOrDefault();
            }
            for (int i = 0; i < candidates.Length; i++)
            {
                if (candidates[i] <= target)
                {

                    list.Add(candidates[i]);
                    currentSum = list.Sum();
                    CombinationSumMethodHelper(candidates, target, currentSum, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
            return currentSum;
        }
    }
}
