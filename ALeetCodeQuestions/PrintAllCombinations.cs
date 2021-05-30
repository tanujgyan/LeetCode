using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class PrintAllCombinations
    {
        public List<List<int>> combine(int[] n, int k)
        {
            List<List<int>> result = new List<List<int>>();

           

            List<int> item = new List<int>();
            dfs(n, k, 0, item, result); // because it need to begin from 1

            return result;
        }
        private void dfs(int[] n, int k, int start, List<int> item,
        List<List<int>> res)
        {
            if (item.Count == k)
            {
                res.Add(new List<int>(item));
                return;
            }

            for (int i = start; i < n.Length; i++)
            {
                item.Add(n[i]);
                dfs(n, k, i + 1, item, res);
                item.RemoveAt(item.Count - 1);
            }
        }
    }
}
