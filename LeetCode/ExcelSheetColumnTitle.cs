using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int columnNumber)
        {
            string s = "";
            while (columnNumber > 0)
            {
                int c = columnNumber % 26!=0? columnNumber % 26:26;
                s = Convert.ToChar(c + 64) + s;
                columnNumber -= c;
                columnNumber = columnNumber / 26;
                continue;


            }
            return s;
        }
    }
}
