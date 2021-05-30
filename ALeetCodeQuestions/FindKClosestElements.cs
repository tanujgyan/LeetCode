using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class FindKClosestElements
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            List<int> closestElements = new List<int>();
            int index = BinarySearch(arr, x);
            
            if (index != -1)
            {
                int leftPointer = index - 1;
                int rightPointer = index + 1;
                closestElements.Add(arr[index]);
                k--;
                while (k > 0)
                {
                    
                    if (rightPointer >= arr.Length)
                    {
                        closestElements.AddRange(GenerateClosestElementsList(arr, 'l', leftPointer, k));
                        break;
                    }
                    if (leftPointer < 0)
                    {
                        closestElements.AddRange(GenerateClosestElementsList(arr, 'r', rightPointer, k));
                        break;
                    }
                    if(Math.Abs(arr[leftPointer]-x)<=Math.Abs(arr[rightPointer]-x))
                    {
                        closestElements.Add(arr[leftPointer]);
                        leftPointer--;
                        k--;
                    }
                    else if (Math.Abs(arr[leftPointer]-x) > Math.Abs(arr[rightPointer]-x))
                    {
                        closestElements.Add(arr[rightPointer]);
                        rightPointer++;
                        k--;
                    }
                }
            }
            closestElements.Sort();
            return closestElements;
        }
        private List<int> GenerateClosestElementsList(int[] arr, char direction, int index, int k)
        {
            List<int> list = new List<int>();
            if (direction == 'l')
            {
                for (int i = index; i >= index - k + 1; i--)
                {
                    list.Add(arr[i]);
                }
            }
            else
            {
                for (int i = index; i<= index + k - 1; i++)
                {
                    list.Add(arr[i]);
                }
            }
            return list;
        }
        private int BinarySearch(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
           
            int mid = -1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (mid >= 0 && mid <= arr.Length - 1)
                {
                    if (arr[mid] == x)
                    {
                        break;
                    }
                    else if (arr[mid] < x)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                else
                {
                    break;
                }
            }
            if(arr[mid]!=x)
            {
                if (arr[mid] > x)
                {
                    if (mid - 1 >= 0 && Math.Abs(arr[mid - 1] - x) <= Math.Abs(arr[mid] - x))
                    {
                        mid = mid - 1;
                    }
                }
                else
                {
                    if(mid+1<=arr.Length-1 && Math.Abs(arr[mid+1]-x)<Math.Abs(arr[mid]-x))
                    {
                        mid = mid + 1;
                    }
                }
            }
            return mid;
        }
    }
}
