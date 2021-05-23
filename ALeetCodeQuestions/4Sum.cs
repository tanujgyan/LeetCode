using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALQ
{
    class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Dictionary<List<int>, int> dict = new Dictionary<List<int>, int>();
            List<IList<int>> result = new List<IList<int>>();
            HashSet<string> hash = new HashSet<string>();
            for (int i = 1; i < nums.Length; i++)
            {
                dict.Add(new List<int> { i - 1, i }, nums[i] + nums[i - 1]);
            }
            for (int i = 0; i < dict.Count; i++)
            {
                for (int j = i + 2; j < dict.Count; j++)
                {
                    if (dict.ElementAt(i).Value + dict.ElementAt(j).Value == target)
                    {
                        StringBuilder sb = new StringBuilder();
                        int[] arr = new int[4];
                        arr[0] = (dict.ElementAt(i).Key[0]);
                        arr[1] = (dict.ElementAt(i).Key[1]);
                        arr[2] = (dict.ElementAt(j).Key[0]);
                        arr[3] = (dict.ElementAt(j).Key[1]);
                        Array.Sort(arr);
                        sb.Append(arr[0]);
                        sb.Append("_");
                        sb.Append(arr[1]);
                        sb.Append("_");
                        sb.Append(arr[2]);
                        sb.Append("_");
                        sb.Append(arr[3]);
                        hash.Add(sb.ToString());
                    }
                }
            }
            foreach(var element in hash)
            {
                var s = element.Split("_");
                List<int> list = new List<int>();
                foreach(var e in s)
                {
                    list.Add(Convert.ToInt32(e));
                }
                result.Add(list);
            }
            return result;
        }
    }
}
