using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hacker_Rank
{
    class LargestRectangleClass
    {
        public int LargestRectangleAreaBruteForce(int[] heights)
        {
            int area = 0;
            int min = 0;
            if (heights.Length == 1)
            {
                return heights[0];
            }
            for (int i = 0; i < heights.Length; i++)
            {
                min = heights[i];
                for (int j = i + 1; j < heights.Length; j++)
                {
                    min = Math.Min(min, heights[j]);
                    area = Math.Max(area, (j - i + 1) * min);
                    area = Math.Max(area, heights[j]);
                }
                area = Math.Max(area, heights[i]);
            }
            return area;
        }
        /// <summary>
        /// 1. We define 2 stacks barheight to store the height of bar and positions to store its index
        /// 2. If stacks are empty we push the first position and first bar height we encounter thats the start of the array
        /// 3. If we get a value which is greater than top of stack we push the height and position. The idea is 
        /// our current stack value can be merged with the coming stack value and will gain length that means bigger area
        /// 4. If we get a value which is smaller than the current top of height stack. Its time to calculate the area.
        /// The idea is since the bigger rectangle (top of stack) cannot be merged into smaller rectangle as it will loose height. So best would be to calculate its area.
        /// The position of the bigger rectangle will tell us where we were so the area will be calculated as height*(index-position).
        /// Index refers to current pointer or i of the for loop
        /// We will pop from height stack but not from position stack.(Why is that!!!!?????)
        /// We check again if the height at top is still bigger we will pop the position stack and repeat the process. the reason for not popping
        /// position stack directly is if the rectangle we are currently dealing with from array is smaller than the rectangle being popped it means
        /// we can merge the smaller one and gain the length advantage
        /// We keep repeating step 4 till we find a value in stack which is lesser than the current array value.
        /// Remember if we find a value which is equal to current array value we will end the loop and not touch the stack
        /// Also everytime we pop stack remember to calculate the area
        /// 5. At the end of for loop if we have stack values left pop them and calculate the are using same way in step 4
        /// 6. No need to mention but everytime we calculate an area keep comparing it with maxarea to see whats the max area we have seen so far.
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public int LargestRectangleAreaStackAlgorithm(int[] heights)
        {
            Stack<int> barHeights = new Stack<int>();
            Stack<int> positions = new Stack<int>();
            int maxarea = 0;
            for(int i=0;i<heights.Length;i++)
            {
                if(barHeights.Count==0 && positions.Count==0)
                {
                    barHeights.Push(heights[i]);
                    positions.Push(i);
                }
                else
                {
                    if(barHeights.Peek()<heights[i])
                    {
                        barHeights.Push(heights[i]);
                        positions.Push(i);
                    }
                    else if(barHeights.Peek()>heights[i])
                    {
                        while (barHeights.Peek() > heights[i])
                        {
                            maxarea = Math.Max((barHeights.Pop() * (i - positions.Peek())), maxarea);
                            if(barHeights.Peek()>heights[i])
                            {
                                positions.Pop();
                            }
                        }
                        barHeights.Push(heights[i]);
                    }
                }
            }
            while(barHeights.Count>0)
            {
                maxarea = Math.Max((barHeights.Pop() * (heights.Length-positions.Pop())),maxarea);
            }
            return maxarea;
        }
    }
}
