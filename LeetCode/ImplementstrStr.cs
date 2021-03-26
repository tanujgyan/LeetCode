using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ImplementstrStr
    {

        /// <summary>
        /// Run the iteration upto a point where needle can fit into haystack
        /// Take the letters of haystack and compare them with needle. Haystack iteration should not increase while comparison is happening
        /// Increment the counter. At the end of inner loop if counter = needle.Lenth that means every character matched successfully. return the 
        /// start index
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            int retVal = -1, counter = 0, tempi = 0;
            if (haystack.Equals(needle) || needle.Length == 0)
            {
                return 0;
            }
            if (needle.Length > haystack.Length)
            {
                return -1;
            }
            for (int i = 0; i < haystack.Length - needle.Length; i++)
            {
                tempi = i;

                for (int j = 0; j < needle.Length; j++)
                {
                    if (tempi < haystack.Length)
                    {
                        if (haystack[tempi] == needle[j])
                        {
                            counter++;
                            tempi++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                if (counter == needle.Length)
                {
                    return i;
                }
                else
                {
                    counter = 0;
                }

            }
            return retVal;
        }
    }
}
