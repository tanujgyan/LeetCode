using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/partition-labels/
    /// </summary>
    class PartitionLabel
    {
        public IList<int> PartitionLabels(string S)
        {
            List<int> partitions = new List<int>();
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
            //add start and end index of characters to a dictionary
            for (int i = 0; i < S.Length; i++)
            {
                if (!dict.ContainsKey(S[i]))
                {
                    dict.Add(S[i], new List<int>() { i });
                    dict[S[i]].Add(i);
                }
                else
                {
                    if (dict[S[i]].Count == 1)
                    {
                        dict[S[i]].Add(i);

                    }
                    else if (dict[S[i]].Count > 1)
                    {
                        dict[S[i]].RemoveAt(1);
                        dict[S[i]].Add(i);
                    }
                }
            }
            List<char> visitedNodes = new List<char>();
            
            //start processing the dictionary
            foreach (var elem in dict)
            {

                if (!visitedNodes.Contains(elem.Key))
                {
                    //get the min and max index of the element to be processed
                    int maxIndex = elem.Value.ElementAt(1);
                    int minIndex = elem.Value.ElementAt(0);
                    //start iterating from the index of the element being processed as the elements before that would have been processed already
                    for (int i = dict.Keys.ToList().IndexOf(elem.Key); i < dict.Count; i++)
                    {
                        if (dict.ElementAt(i).Key != elem.Key && !visitedNodes.Contains(dict.ElementAt(i).Key))
                        {
                            //if we find an element that lies between the min and max of the element being processed
                            if (dict.ElementAt(i).Value[0] > minIndex && dict.ElementAt(i).Value[0] < maxIndex)
                            {
                                //once a node is processed add it to visited nodes so it will not be processed again
                                visitedNodes.Add(dict.ElementAt(i).Key);
                                //check if the element found has a greater max index than element being processed.
                                //this will increase the maxindex of the partition to be created.
                                if (dict.ElementAt(i).Value[1] > maxIndex)
                                {
                                    maxIndex = dict.ElementAt(i).Value[1];
                                }
                            }
                        }
                    }

                    //once a node is processed add it to visited nodes
                    visitedNodes.Add(elem.Key);
                    //add the partition size
                    partitions.Add(maxIndex - minIndex + 1);

                }
            }
            return partitions;
        }
    }
}
