using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/valid-mountain-array/
    /// </summary>
    class MountainArrayClass
    {
        public bool ValidMountainArray(int[] arr)
        {
            bool max = false;
            int increment = 0;
            int decrement = 0;
            //if length is less than 3 or if the array goes down initially instead of going up
            if (arr.Length < 3 || arr[0] >= arr[1])
            {
                return false;
            }
            
            else
            {
                for(int i=1;i<arr.Length;i++)
                {
                    //initially the mountain will go up
                    if(!max)
                    {
                        if(arr[i]>arr[i-1])
                        {
                            increment++;
                            continue;
                        }
                        //if you find a decreasing instance set max as true
                        else if(arr[i]<arr[i-1])
                        {
                            decrement++;
                            max = true;
                        }
                        else if(arr[i]==arr[i-1])
                        {
                            return false;
                        }
                    }
                    //this will start getting executed when max is true
                    else
                    {
                        //wee expect only decrement from here on
                        if(arr[i]>=arr[i-1])
                        {
                            return false;
                        }
                        decrement++;
                    }
                }
                //both increment and decrement should have happened
                if(increment>0 && decrement>0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
