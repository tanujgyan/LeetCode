using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudyPlan
{
    //Time complexity O(nlogn)
    class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            Sort<int>(intervals, 0); // O(nlogn)
            Dictionary<int?, int> dict = new Dictionary<int?, int>();
            dict.Add(intervals[0][0], intervals[0][1]);
            for(int i=1;i<intervals.Length;i++) //O(n)
            {
                var temp = dict.FirstOrDefault(x => x.Key <= intervals[i][0] && x.Value>=intervals[i][0]).Key;
                if(temp!=null)
                {
                    if(dict[temp]<intervals[i][1])
                    {
                        dict[temp] = intervals[i][1];
                    }
                }
                else
                {
                    dict.Add(intervals[i][0], intervals[i][1]);
                }
            }
            int[][] result = new int[dict.Count][];
            for (int i=0;i<dict.Count;i++) //O(n)
            {
                result[i] = new int[] { (int)dict.ElementAt(i).Key, dict.ElementAt(i).Value };
                //result[i][1] = dict.ElementAt(i).Value;
            }
            return result;
        }
        private static void Sort<T>(T[][] data, int col)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            Array.Sort<T[]>(data, (x, y) => comparer.Compare(x[col], y[col]));
        }
    }
}
