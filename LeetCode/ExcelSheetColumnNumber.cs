using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ExcelSheetColumnNumber
    {
        public double TitleToNumber(string columnTitle)
        {
            double result = 0;
            for(int i=0;i<columnTitle.Length;i++)
            {
                result+=(columnTitle[i] - 64) * Math.Pow(26, columnTitle.Length - i-1);
            }
            return result;
        }
    }
}
