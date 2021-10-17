using System;
using System.Collections.Generic;
using System.Text;

namespace StudyPlan
{
    class HouseRobber
    {
        public int Rob(int[] nums)
        {
            int[] result = new int[nums.Length];
            if(nums.Length>2)
            {
                result[0] = nums[0];
                result[1] = nums[1];
                for (int i = 2; i < nums.Length; i++)
                {
                    int possibility1 = -1, possibility2 = -1;
                    if(i-2>=0)
                    {
                        possibility1 = nums[i] + result[i - 2];
                    }
                    if (i - 3 >= 0)
                    {
                        possibility2 = nums[i] + result[i - 3];
                    }

                    result[i] = Math.Max(possibility1, possibility2);
                }
                return Math.Max(result[nums.Length - 1], result[nums.Length - 2]);
            }
            else if(nums.Length==2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            else if(nums.Length==1)
            {
                return nums[0];
            }
            return int.MaxValue;
        }
    }
}
