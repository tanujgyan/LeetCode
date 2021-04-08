using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class AddBinary
    {
        public string AddBinaryMethod(string a, string b)
        {
            return Convert.ToString((Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2)),2);
        }
    }
}
