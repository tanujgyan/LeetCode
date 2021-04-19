using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/can-place-flowers/
    /// </summary>
    class CanPlaceFlowersClass
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (flowerbed.Length == 1 && flowerbed[0] == 0)
            {
                n--;
            }
            else
            {
                for (int i = 0; i < flowerbed.Length; i++)
                {
                    if (flowerbed[i] == 0 && i - 1 >= 0 && i + 1 <= flowerbed.Length - 1 && flowerbed[i - 1] != 1 && flowerbed[i + 1] != 1)
                    {
                        n--;
                        flowerbed[i] = 1;
                    }
                    else if (i == 0 && i + 1 <= flowerbed.Length - 1 && flowerbed[1] != 1 && flowerbed[0] == 0)
                    {
                        n--;
                        flowerbed[0] = 1;
                    }
                    else if (i == flowerbed.Length - 1 && flowerbed.Length - 2 >= 0 && flowerbed[flowerbed.Length - 2] != 1 && flowerbed[flowerbed.Length - 1] != 1)
                    {
                        n--;
                        flowerbed[flowerbed.Length - 1] = 1;
                    }
                    if (n == 0)
                    {
                        return true;
                    }
                }
            }
            if (n == 0)
                return true;
            return false;
        }
    }
}
