using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class RottingOranges
    {
        int minutes = 0;
        public int OrangesRotting(int[][] grid)
        {
            bool changed = false;
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        if (i - 1 >= 0 && grid[i - 1][j] == 1)
                        {
                            if (!dict.ContainsKey(i - 1 + "_" + j))
                            {
                                //  grid[i - 1][j] = 2;
                                dict.Add((i - 1) + "_" + j, true);
                                changed = true;
                            }
                        }
                        if (i + 1 < grid.Length && grid[i + 1][j] == 1)
                        {
                            if (!dict.ContainsKey((i + 1) + "_" + j))
                            {
                                // grid[i + 1][j] = 2;
                                dict.Add(i + 1 + "_" + j, true);
                                changed = true;
                            }
                        }
                        if (j - 1 >= 0 && grid[i][j - 1] == 1)
                        {
                            if (!dict.ContainsKey(i + "_" + (j - 1)))
                            {
                                // grid[i][j-1] = 2;
                                dict.Add(i + "_" + (j - 1), true);
                                changed = true;
                            }
                        }
                        if (j + 1 < grid[i].Length && grid[i][j + 1] == 1)
                        {
                            if (!dict.ContainsKey(i + "_" + (j + 1)))
                            {
                                //  grid[i][j+1] = 2;
                                dict.Add(i + "_" + (j + 1), true);
                                changed = true;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < dict.Count; i++)
            {
                if (dict.ElementAt(i).Value == true)
                {
                    var row = Convert.ToInt32(dict.ElementAt(i).Key.Split("_")[0]);
                    var column = Convert.ToInt32(dict.ElementAt(i).Key.Split("_")[1]);
                    grid[row][column] = 2;
                }
            }
            if (changed == true)
            {
                minutes++;
                OrangesRotting(grid);
            }
            else if (changed == false)
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if(grid[i][j]==1)
                        {
                            minutes = -1;
                            //return -1;
                        }
                    }
                }
            }
            return minutes;

        }
    }
}
