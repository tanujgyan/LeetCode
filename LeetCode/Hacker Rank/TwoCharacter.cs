using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Hacker_Rank
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/two-characters/problem
    /// </summary>
    class TwoCharacter
    {
        /// <summary>
        /// 1. Find all the characters in string which are distinct and save them in a list
        /// 2. Create a matrix with rows and columns as number of distinct characters. The matrix can be seen as a excel sheet with rows and columns
        /// labelled as distinct characters name. For example if first character is 'b' so complete row 0 and complete column 0 will belong to b 
        /// 3. Start parsing the string character by character. We have to fill the values of characters in the matrix
        ///    find the index of the character from list. we have to fill the row value of the index and column value of the index with char.
        ///    Not just one cell but whole row and whole column
        ///    a. If the cell we are trying to fill has X in it skip it
        ///    b. if the cell is blank add it
        ///    c. If the cell already has a string check the last char of string if it is same as char being processed mark the cell as X
        ///    otherwise append the char to string.
        ///    
        /// Repeat step 3 till we parse the string.
        /// 4. At the end go through matrix and find the string which is not X and has maxlength. that will be answer
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int alternate(string s)
        {
            HashSet<char> distinctChars = new HashSet<char>();
            foreach(char c in s)
            {
                distinctChars.Add(c);
            }
            var distinctList = distinctChars.ToList();
            string[][] dpmatrix = new string[distinctChars.Count][];
            int dpmatrixrowcolumnCount = distinctChars.Count;
            //initialize dp matrix
            for(int i=0;i<dpmatrix.Length;i++)
            {
                dpmatrix[i] = new string[dpmatrixrowcolumnCount];
                for(int j=0;j< dpmatrixrowcolumnCount;j++ )
                {
                    dpmatrix[i][j] = "";
                }
            }
            foreach (char c in s)
            {
                int indexOfChar = distinctList.IndexOf(c);
                //fill the rows 
                for (int i=0;i< dpmatrixrowcolumnCount; i++)
                {
                    if(string.IsNullOrEmpty(dpmatrix[i][indexOfChar]))
                    {
                        dpmatrix[i][indexOfChar]+=c;
                    }
                    else if(dpmatrix[i][indexOfChar].ToString()!="X" && dpmatrix[i][indexOfChar][dpmatrix[i][indexOfChar].Length-1] !=c)
                    {
                        dpmatrix[i][indexOfChar]+=c;
                    }
                    else if(dpmatrix[i][indexOfChar][dpmatrix[i][indexOfChar].Length - 1]==c)
                    {
                        dpmatrix[i][indexOfChar] = "X";
                    }
                }
                //fill the columns
                for (int j = 0; j < dpmatrixrowcolumnCount; j++)
                {
                    if (string.IsNullOrEmpty(dpmatrix[indexOfChar][j]))
                    {
                        dpmatrix[indexOfChar][j]+=c;
                    }
                    else if (dpmatrix[indexOfChar][j].ToString() != "X" && dpmatrix[indexOfChar][j][dpmatrix[indexOfChar][j].Length - 1] != c)
                    {
                        dpmatrix[indexOfChar][j]+=c;
                    }
                    else if (dpmatrix[indexOfChar][j][dpmatrix[indexOfChar][j].Length - 1] == c)
                    {

                        dpmatrix[indexOfChar][j] = "X";
                    }
                }
            }
            int maxLength = 0;
            for(int i=0;i<dpmatrixrowcolumnCount;i++)
            {
                for(int j=0;j<dpmatrixrowcolumnCount;j++)
                {
                    if(dpmatrix[i][j]!="X")
                    {
                        maxLength = maxLength >= dpmatrix[i][j].Length ? maxLength : dpmatrix[i][j].Length;
                    }
                }
            }
            return maxLength;
        }
    }
}
