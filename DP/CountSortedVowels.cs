using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP
{
    class CountSortedVowels
    {
        public static int CountVowelStrings(int n)
        {
          
            int[] dparray = new int[] { 1, 1, 1, 1, 1 }; //this is base condition for N=1
           

            //the calculation logic is for N=2 is 
            //number of a based strings = total size of array for N=1
            //number of e based strings = total size of array for N=1 - number of a in array of N=1
            //number of i based strings = total size of array for N=1 - number of e in array of N=1
            //number of o based strings = total size of array for N=1 - number of i in array of N=1
            //number of u based strings = total size of array for N=1 - number of o in array of N=1

            //generalizing the logic if we need to calculate total number of substrings for N=n
            //number of a based strings = total size of array for N=n-1
            //number of e based strings = total size of array for N=n-n-1- number of a in array of N=n-1
            //number of i based strings = total size of array for N=n-1 - number of e in array of N=n-1
            //number of o based strings = total size of array for N=n-1 - number of i in array of N=n-1
            //number of u based strings = total size of array for N=n-1 - number of o in array of N=n-1

            for(int i=1;i<n;i++)
            {
                int[] tempdparray = new int[5];
                Array.Copy(dparray, tempdparray, 5);
                int total = tempdparray.Sum();
                dparray[0] = total;
                for(int j=1;j<5;j++)
                {
                    dparray[j] = dparray[j - 1] - tempdparray[j - 1];
                }
            }
            int result = dparray.Sum();
            return result;
        }
    }
}
