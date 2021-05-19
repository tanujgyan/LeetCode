using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    /// <summary>
    /// https://www.geeksforgeeks.org/next-greater-element/#:~:text=The%20Next%20greater%20Element%20for,next%20greater%20element%20as%20%2D1.
    /// </summary>
    class NextGreaterElement
    {
        public int[] NextGreaterElementMethod(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>();
           
            for(int i=nums.Length-1;i>=0;i--)
            {
                if(stack.Count==0)
                {
                    result.Add(-1);
                    stack.Push(nums[i]);
                }
                else
                {
                    while(stack.Count>0)
                    {
                        if(stack.Peek()>nums[i])
                        {
                            result.Add(stack.Peek());
                            stack.Push(nums[i]);
                            break;
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                    if(stack.Count==0)
                    {
                        result.Add(-1);
                        stack.Push(nums[i]);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
