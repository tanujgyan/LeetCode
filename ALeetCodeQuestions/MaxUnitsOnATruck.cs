using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// https://leetcode.com/problems/maximum-units-on-a-truck/
/// </summary>
namespace ALQ
{
    /// <summary>
    /// This is similar to fractional knapsack and will be solved using greedy algorithm
    /// This is different from traditional fractional knapsack in the sense that the weight of each item is 1
    /// unlike traditional problem where the weight is the second element of the array
    /// </summary>
    class MaxUnitsOnATruck
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            var boxes = InitializeBoxes(boxTypes);
            BoxComparer boxComparer = new BoxComparer();
            Array.Sort(boxes, boxComparer);
            int currentSize = 0;
            int maxValue = 0;
            foreach (var box in boxes)
            {
                if (currentSize < truckSize && box.numberOfBoxes + currentSize <= truckSize)
                {
                    maxValue += (box.numberOfBoxes * box.valueOfBoxes);
                    currentSize += box.numberOfBoxes;
                }
                else if (currentSize < truckSize && box.numberOfBoxes + currentSize > truckSize)
                {
                    int remaining = truckSize - currentSize;
                    maxValue += (remaining * box.valueOfBoxes);
                    break;
                }
            }
            return maxValue;
        }
        private Box[] InitializeBoxes(int[][] boxTypes)
        {
            Box[] boxes = new Box[boxTypes.Length];
            for (int i = 0; i < boxTypes.Length; i++)
            {
                boxes[i] = new Box(boxTypes[i][0], boxTypes[i][1]);
            }
            return boxes;
        }
    }
    class Box
    {
        public int numberOfBoxes { get; set; }
        public int valueOfBoxes { get; set; }
        public Box(int _numberOfBoxes, int _valueOfBoxes)
        {
            numberOfBoxes = _numberOfBoxes;
            valueOfBoxes = _valueOfBoxes;
        }
    }
    class BoxComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Box box1 = (Box)x;
            Box box2 = (Box)y;
          //  double ratio1 = (double)box1.valueOfBoxes / (double)box1.numberOfBoxes;
           // double ratio2 = (double)box2.valueOfBoxes / (double)box2.numberOfBoxes;
            if (box1.valueOfBoxes<box2.valueOfBoxes)
            {
                return 1;
            }
            else if (box1.valueOfBoxes > box2.valueOfBoxes)
            {
                return -1;
            }
            return 0;
        }
    }
}
