using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int i = 0;
            int j = height.Length - 1;
            
            while(true)
            {
                int potentialMaxArea = 0;
               
                if (height[i]>height[j])
                {
                    potentialMaxArea = height[j] * (j - i);
                    j--;
                    
                }
                else if(height[i]<height[j])
                {
                    potentialMaxArea = height[i] * (j - i);
                    i++;
                    
                }
                else
                {
                    potentialMaxArea = height[j] * (j - i);
                    if (height[i+1]>height[j-1])
                    {
                        j--;
                       
                    }
                    else if(height[i+1]<height[j-1])
                    {
                        i++;
                       
                    }
                    else
                    {
                        i++;
                        j--;
                       
                    }
                }
                
                if (potentialMaxArea>maxArea)
                {
                    maxArea = potentialMaxArea;
                }
                if(i>=j)
                {
                    break;
                }
            }
            return maxArea;
        }
    }
}
