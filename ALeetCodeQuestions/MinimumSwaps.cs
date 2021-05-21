using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALQ
{
    class MinimumSwaps
    {
        public int minimumSwaps(int[] arr)
        {
            int swaps = 0;
            int inputLength = arr.Length;
            int[] sortedArray = new int[inputLength];
            Array.Copy(arr, sortedArray, inputLength);
            HeapSort(sortedArray);
            Dictionary<int, int> mapping = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                mapping.Add(arr[i], i);
            }
            for (int i = 0; i < inputLength; i++)
            {
                var currentIndex = mapping[sortedArray[i]];
                if (currentIndex != i)
                {
                    swaps++;
                    mapping[sortedArray[i]] = i;
                    mapping[arr[i]] = currentIndex;
                    Swap(arr, i, currentIndex);
                }
            }
            return swaps;
        }
        private void HeapSort(int[] sortedArray)
        {
            int inputLength = sortedArray.Length;

            for (int i = inputLength / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(sortedArray, inputLength, i);
            }
            for (int i = inputLength - 1; i >0; i--)
            {
                Swap(sortedArray, i, 0);
                MaxHeapify(sortedArray, i, 0);
            }
        }
        private void MaxHeapify(int[] arr, int lengthOfArray, int indexToBeHeapified)
        {
            int largestIndex = indexToBeHeapified;
            int left = 2 * indexToBeHeapified + 1;
            int right = 2 * indexToBeHeapified + 2;
            if (left < lengthOfArray && arr[largestIndex] < arr[left])
            {
                largestIndex = left;
            }
            if (right < lengthOfArray && arr[largestIndex] < arr[right])
            {
                largestIndex = right;
            }
            if (largestIndex != indexToBeHeapified)
            {
                Swap(arr, indexToBeHeapified, largestIndex);
                MaxHeapify(arr, lengthOfArray, largestIndex);
            }
        }
        private void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

    }
}
