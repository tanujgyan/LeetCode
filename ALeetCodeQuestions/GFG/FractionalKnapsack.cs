using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ALQ.GFG
{
    class FractionalKnapsack
    {
        public double FracKnapSack(item[] items, int w)
    {

        // Sort items based on cost per units
        cprCompare cmp = new cprCompare();
        Array.Sort(items, cmp);


        // Traverse items, if it can fit,
        // take it all, else take fraction
        double totalVal = 0f;
        int currW = 0;

        foreach (item i in items)
        {
            float remaining = w - currW;

            // If the whole item can be
            // taken, take it
            if (i.weight <= remaining)
            {
                totalVal += (double)i.value;
                currW += i.weight;
            }

            // dd fraction untill we run out of space
            else
            {
                if (remaining == 0)
                    break;

                double fraction = remaining / (double)i.weight;
                totalVal += fraction * (double)i.value;
                currW += (int)(fraction * (double)i.weight);
            }
        }
        return totalVal;
    }
    }
    class item
    {
        public int value;
        public int weight;

        public item(int value, int weight)
        {
            this.value = value;
            this.weight = weight;
        }
    }
    class cprCompare : IComparer
    {
        public int Compare(Object x, Object y)
        {
            item item1 = (item)x;
            item item2 = (item)y;
            double cpr1 = (double)item1.value /
                          (double)item1.weight;
            double cpr2 = (double)item2.value /
                          (double)item2.weight;

            if (cpr1 < cpr2)
                return 1;

            return cpr1 > cpr2 ? -1 : 0;
        }
    }
    
}
