using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/robot-return-to-origin/
    /// </summary>
    class RobotReturnToOrigin
    {
        int[] arr = new int[2] { 0, 0 };
        public bool JudgeCircle(string moves)
        {
            foreach (char c in moves)
            {
                if(c=='L')
                {
                    arr[0] -= 1;
                }
                else if (c == 'R')
                {
                    arr[0] += 1;
                }
                if (c == 'D')
                {
                    arr[1] -= 1;
                }
                if (c == 'U')
                {
                    arr[1] += 1;
                }
            }
            if(arr[0]==0 && arr[1]==0)
                    return true;
            return false;
        }
    }
}
