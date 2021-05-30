using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// In order to improve customer experience, Amazon has developed a system to provide recommendations to the customer regarding the item they can purchase. Based on historical customer purchase information, an item association can be defined as - If an item A is ordered by a customer, then item B is also likely to be ordered by the same customer (e.g. Book 1 is frequently orderered with Book 2). All items that are linked together by an item association can be considered to be in the same group. An item without any association to any other item can be considered to be in its own item association group of size 1.

//Given a list of item association relationships(i.e. group of items likely to be ordered together), write an algorithm that outputs the largest item association group. If two groups have the same number of items then select the group which contains the item that appears first in lexicographic order.

//Input
//The itput to the function/method consists of an argument - itemAssociation, a list containing paris of string representing the items that are ordered together.

//Output
//Return a list of strings representing the largest association group sorted lexicographically.

//Example
//Input:
//itemAssociation:[
//[Item1, Item2],
//[Item3, Item4],
//[Item4, Item5]
//]

//Output:
//[Item3, Item4, Item5]

//Explanation:
//There are two item association groups:
//group1:[Item1, Item2]
//group2:[Item3, Item4, Item5]
//In the available associations, group2 has the largest association. So, the output is [Item3, Item4, Item5].
/// </summary>
namespace ALQ
{
    /// <summary>
    /// This can be solved using standard DFS
    /// The idea is to take first build an adjacency list. Then take nodes one by one and run DFS on them
    /// At the end of a node's run we will have all associated nodes in a temp list
    /// Compare temp list count with result count and if temp is greater than result copy temp to result
    /// If result and temp are equal in count then convert them to comma separated string and compare them using Compare function 
    /// and if temp is lexographically smaller than result then replace result with temp.
    /// </summary>
    class LargestItemAssociation
    {
        Dictionary<string, List<string>> adjacencyList = new Dictionary<string, List<string>>();
        
        public void LargestItemAssociationMethod(List<Tuple<string, string>> itemAssociation)
        {
            BuildAdjacencyList(itemAssociation);
            List<string> visited = new List<string>();
            List<string> result = new List<string>();

            foreach(var item in itemAssociation)
            {
               
                List<string> temp = new List<string>();
                LargestItemAssociationMethodHelper(visited, item.Item1, temp);
                if(temp.Count>result.Count)
                {
                    temp.Sort();
                    result = new List<string>(temp);
                }
                else if(result.Count==temp.Count)
                {
                    result.Sort();
                    temp.Sort();
                    var r = String.Join(",", result);
                    var t= String.Join(",", temp);
                    var output = string.CompareOrdinal(r, t);
                    if(output>0)
                    {
                        result = new List<string>(temp);
                    }
                    
                }

            }
        }
        private void LargestItemAssociationMethodHelper(List<string> visited,string node,List<string> temp)
        {
            if(visited.Contains(node))
            {
                return;
            }
            visited.Add(node);
            temp.Add(node);
            if(adjacencyList.ContainsKey(node))
            {
                foreach(var neghibor in adjacencyList[node])
                {
                    LargestItemAssociationMethodHelper(visited, neghibor,temp);
                }
            }
        }
        private void BuildAdjacencyList(List<Tuple<string, string>> itemAssociation)
        {
            foreach (var item in itemAssociation)
            {
                if(adjacencyList.ContainsKey(item.Item1))
                {
                    adjacencyList[item.Item1].Add(item.Item2);
                }
                else
                {
                    adjacencyList.Add(item.Item1, new List<string>() { item.Item2 });
                }
            }
        }
    }
}
