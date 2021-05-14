using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    class RotateStringClass
    {
       
        public bool RotateString(string s, string goal)
        {
            int count = s.Length;
            bool returnVal = false;
            if (count != goal.Length)
            {
                return false;
            }
            if(count==0 && goal.Length==0)
            {
                return true;
            }
            List<int> indexes = GetAllIndexes(goal, s[0]);
            foreach (var l in indexes)
            {
                int rotation = FindRotation(s, goal,l);
                bool flag = true;
                for (int i = 1; i < s.Length; i++)
                {
                    int expectedIndex = i - rotation < 0 ? count - Math.Abs(i - rotation) : i - rotation;
                    char expectedChar = s[i];
                    var r = CheckCharactersPosition(expectedChar, expectedIndex, goal);
                    if (r==false)
                    {
                        flag = false;
                        break;
                    }
                    
                }
                if(flag)
                {
                    returnVal = true;
                    break;
                }
            }
          
           
            return returnVal;
        }
        private int FindRotation(string s, string goal,int newIndex)
        {
           int totalCount = s.Length;
           int rotation = totalCount - Math.Abs(0- newIndex);
           return rotation;
        }
        private bool CheckCharactersPosition(char expectedChar,int expectedIndex, string goal)
        {
            if(expectedChar==goal[expectedIndex])
            {
                return true;
            }
            return false;
        }

        private List<int> GetAllIndexes(string goal, char c)
        {
            List<int> index = new List<int>();
            for(int i=0;i<goal.Length;i++)
            {
                if(c==goal[i])
                {
                    index.Add(i);
                }
            }
            return index;
        }
    }
}
