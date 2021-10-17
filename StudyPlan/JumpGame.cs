using System;
using System.Collections.Generic;
using System.Text;

namespace StudyPlan
{
    //Run time complexity is O(n)
    //The idea is simple we have to assume we are at the end point. We mark that as golden point
    //Then we go back and find the first golden point which means the first index from where we //can jump to golden point. 
    //Once we find the index we mark that as golden point and then we continue going back and keep chnanging the golden points. 
    //If we can mark 0th index as golden point than we got true as answer otherwise false.
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            bool result = true;
            bool[] goldenArray = new bool[nums.Length];
            goldenArray[nums.Length - 1]= true;
            int lastGoldenIndex = nums.Length - 1;
            for(int i=nums.Length-2;i>=0;i--)
            {
                goldenArray[i] = CanWeReachAGoldenPointFromHere(i, lastGoldenIndex, nums[i], goldenArray);
                if (goldenArray[i])
                {
                    lastGoldenIndex = i;
                }
                result = goldenArray[i];
            }
            return result;
        }
        public bool CanWeReachAGoldenPointFromHere(int startIndex, int lastGoldenIndex, int length, bool[] goldenArray)
        {
           if(startIndex+length>= lastGoldenIndex)
            {
                return true;
            }
            return false;
        }
    }
}
