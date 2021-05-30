using System;
using System.Collections.Generic;
using System.Text;

namespace ALQ
{
    class HeapSort
    {
        public void HeapSortMethod(int[] arr)
        {
            int inputLength = arr.Length;
            //Call max Heapify on all non leaf nodes
            for(int i=inputLength/2-1;i>=0;i--)
            {
                MaxHeapify(arr, inputLength, i);
            }
            for(int i=inputLength-1;i>=0;i--)
            {
                //swap the last element as it will be on its correct position
                Swap(arr, 0, i);
                //notice how we are chaning the array size to disconnect the last element which is already at position
                MaxHeapify(arr, i, 0);
            }
            foreach(var e in arr)
            {
                Console.WriteLine(e);
            }
        }
        private void MaxHeapify(int[] arr, int lengthOfArray, int indexToBeHeapified)
        {
            int largestIndex = indexToBeHeapified;
            int leftChild = 2 * indexToBeHeapified + 1;
            int rightChild = 2 * indexToBeHeapified + 2;
            if(leftChild<lengthOfArray && arr[largestIndex]<arr[leftChild])
            {
                largestIndex = leftChild;
            }
            if(rightChild<lengthOfArray && arr[largestIndex] < arr[rightChild])
            {
                largestIndex = rightChild;
            }
            if(largestIndex!=indexToBeHeapified)
            {
                Swap(arr, largestIndex, indexToBeHeapified);
                MaxHeapify(arr, lengthOfArray, largestIndex);
            }
        }
        private void Swap(int[] arr,  int element1,  int element2)
        {
            int temp = arr[element1];
            arr[element1] = arr[element2];
            arr[element2] = temp;
        }
    }
}
