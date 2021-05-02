using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Code_Line
{
    class GroupingDishes
    {
       public string[][] groupingDishes(string[][] dishes)
        {
            Dictionary<string, List<string>> groupingDict = new Dictionary<string, List<string>>(StringComparer.InvariantCultureIgnoreCase);
            int rowLength = dishes.Length;
            int columnLength = dishes[0].Length;
            for(int i=0;i<rowLength; i++)
            {
                for(int j=1;j<dishes[i].Length;j++)
                {
                    if(!groupingDict.ContainsKey(dishes[i][j]))
                    {
                        groupingDict.Add(dishes[i][j], new List<string>() {dishes[i][0] });
                    }
                    else
                    {
                        groupingDict[dishes[i][j]].Add(dishes[i][0]);
                    }
                }
            }
            //remove any ingredient with only one dish
            for(int i=0;i<groupingDict.Count;)
            {
                if(groupingDict.ElementAt(i).Value.Count==1)
                {
                    groupingDict.Remove(groupingDict.ElementAt(i).Key);
                }
                //order lexographically the dishes for each ingredient
                else
                {
                    groupingDict.ElementAt(i).Value.Sort(StringComparer.Ordinal);
                    i++;
                }
            }
            //order by key
            groupingDict=groupingDict.OrderBy(x => x.Key, StringComparer.Ordinal).ToDictionary(x => x.Key, x => x.Value);
            string[][] result = new string[groupingDict.Count][];
            int counter = 0;
            foreach(var element in groupingDict)
            {
                result[counter] = new string[element.Value.Count + 1];
                result[counter][0] = element.Key;
                int tempvalCounter = 1;
                foreach(var val in element.Value)
                {
                    result[counter][tempvalCounter] = val;
                    tempvalCounter++;
                }
                counter++;
            }
            return result;
        }
    }
}
