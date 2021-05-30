using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Given an array containing only positive integers, return if you can pick two integers from the array which cuts the array into three pieces such that the sum of elements in all pieces is equal.

//Example 1:

//Input: array = [2, 4, 5, 3, 3, 9, 2, 2, 2]

//Output: true

//Explanation: choosing the number 5 and 9 results in three pieces[2, 4], [3, 3] and [2, 2, 2]. Sum = 6.

//Example 2:

//Input: array =[1, 1, 1, 1],

//Output: false
/// </summary>
namespace ALQ
{
    class LoadBalancer
    {
        public bool LoadBalancerMethod(int[] arr)
        {
            if(arr.Length<5)
            {
                return false;
            }
            int total = arr.Sum();
            //we cannot drop first element or last element
            //we need to start with two pointers and we need to move the pointers towards each other while calculating left half sum
            //right half sum and middle sum
            int leftSum = arr[0];
            int rightSum = arr[arr.Length - 1];
            int leftPointer = 1;
            int rightPointer = arr.Length - 2;
            int midSum = total - leftSum - rightSum - leftPointer - rightPointer;
            //Just an initial check before we start loop
            if(leftSum==rightSum && leftSum==midSum)
            {
                return true;
            }
            //the loop will run until there is a lefthalf -->leftPointer --- mid ---right Pointer <-- right half
            //so difference between right and left pointer should be 2
            while(rightPointer-leftPointer>=2)
            {
                midSum = total - leftSum - rightSum - leftPointer - rightPointer;
                if (leftSum == rightSum && leftSum == midSum)
                {
                    return true;
                }
                if (leftSum>rightSum)
                {
                    rightSum += rightPointer;
                    rightPointer--;
                }
                else if(leftSum<rightSum)
                {
                    leftSum += leftPointer;
                    leftPointer++;
                }
                else
                {
                    rightSum += rightPointer;
                    rightPointer--;
                    leftSum += leftPointer;
                    leftPointer++;
                }

            }
            return false;
        }
    }
}
