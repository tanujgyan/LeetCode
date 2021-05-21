using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALQ
{
    /// <summary>
    /// https://leetcode.com/problems/count-of-smaller-numbers-after-self/
    /// </summary>
    class CountSmallerElementsOnRightSide
    {
        /// <summary>
        /// The idea behind algorithm is to utilize binary search for reducing time complexity
        /// We will start iterating the array from last element. At any point of time we take the element and add it to a list
        /// The element must be inserted to list in sorted order. 
        /// For getting the element position we will use binary search and insert the element at right position
        /// Once we find the position of element we use the index to determine how many elements were before that and that will
        /// be the count of smaller elements in the array after that
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] CountSmallerOnRight(int[] arr)
        {
            List<int> list = new List<int>();
            int[] result = new int[arr.Length];
            for(int i=arr.Length-1;i>=0;i--)
            {
                result[i] = AddToList(list, arr[i]);
            }
            return result;
        }
        //Add the element to list
        private int AddToList(List<int> list, int element)
        {
            int result = 0;
            if(list.Count==0)
            {
                list.Add(element);
            }
            else
            {
                result = BinarySearch(list, element, 0, list.Count - 1);
            }
            return result;
        }
        //Find the position at which the element should be inserted
        private int BinarySearch(List<int> list,int element,int leftIndex,int rightIndex)
        {
            int result = 0;
            
            while (true)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                if(element<list[0])
                {
                    list.Insert(0, element);
                    result = 0;
                    break;
                }
                else if(element>list[list.Count-1])
                {
                    result = list.Count;
                    list.Add(element);
                    break;
                    
                }
                else if (list.ElementAt(middleIndex) < element && middleIndex+1<=list.Count-1 && list.ElementAt(middleIndex + 1) > element)
                {
                    list.Insert(middleIndex+1, element);
                    result = middleIndex+1;
                    break;
                }
                else if (list.ElementAt(middleIndex) > element && middleIndex - 1 >=0 && list.ElementAt(middleIndex - 1) < element)
                {
                    list.Insert(middleIndex, element);
                    
                    result = middleIndex;
                    break;
                }
                else if(list.ElementAt(middleIndex)==element)
                {
                    list.Insert(middleIndex, element);
                    while(middleIndex >= 0 && list[middleIndex]==element)
                    {
                        middleIndex--;
                    }
                    result = middleIndex + 1;
                    break;
                }
                else if(element>list[middleIndex])
                {
                    leftIndex = middleIndex + 1;
                }
                else if(element<list[middleIndex])
                {
                    rightIndex = middleIndex - 1;
                }
            }
            return result;
        }
    }
}
