using System;
using System.Collections.Generic;
using System.Text;

namespace StudyPlan
{
    class FirstBadVersionClass
    {
        public int FirstBadVersion(int n)
        {
            int low = 0;
            int high = n - 1;
           
            while(high>=low)
            {
                int mid = low + ((high - low) / 2);
                Console.WriteLine(mid);
                if(IsBadVersion(mid))
                {
                    if((mid-1>=0 && !IsBadVersion(mid-1))|| (mid-1<0))
                    {
                        return mid;
                    }
                    else if(mid - 1 >= 0 && IsBadVersion(mid - 1))
                    {
                        high = mid - 1;
                    }
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        private bool IsBadVersion(double mid)
        {
            bool[] arr = new bool[] { false,false,false,true,true};
            return arr[(int)mid];
        }
    }
}
