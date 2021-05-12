using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Amazon_Interview_Questions
{
    /// <summary>
    /// https://leetcode.com/problems/reorganize-string/
    /// </summary>
    class ReorganizeStringClass
    {
        public string ReorganizeString(string S)
        {
            Dictionary<char, int> mapping = new Dictionary<char, int>();
            //create mapping object that will have key as char and value as frequency of the char
            for (int i = 0; i < S.Length; i++)
            {
                if (!mapping.ContainsKey(S[i]))
                    mapping.Add(S[i], 1);
                else
                    mapping[S[i]]++;
            }
            //sort the dictionary based on value
            mapping = mapping.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            StringBuilder finalstring = new StringBuilder("");
        //this loop will continue till there are atleast 2 unique elements in dictionary
           while(mapping.Count>=2)
            {
                int i = 0;
                //make sure it doesn't go out of bounds
                if(i+1<mapping.Count)
                {
                    char key1 = mapping.ElementAt(i).Key;
                    char key2 = mapping.ElementAt(i + 1).Key;
                    //take the top 2 characters and place them in alternate fashion
                    for(int j=0;j<mapping.ElementAt(i+1).Value;j++)
                    {
                        finalstring.Append( mapping.ElementAt(i).Key);
                        mapping[mapping.ElementAt(i).Key]--;
                        finalstring.Append(mapping.ElementAt(i+1).Key);
                        mapping[mapping.ElementAt(i+1).Key]--;
                    }
                    //after processing is done check if either of the element was exhausted
                    //2nd element will always be exhausted
                    //remove the exhausted element from dictionary
                    if(mapping[key1]==0)
                    {
                        mapping.Remove(key1);
                    }
                    if (mapping[key2] == 0)
                    {
                        mapping.Remove(key2);
                    }
                    //re-sort the dictionary
                    mapping = mapping.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                }
            }
           //check for leftover element. There will be either 1 or 0 elements left
            if (mapping.Count > 0)
            {
               while(mapping[mapping.ElementAt(0).Key]>0)
                {
                   //if final string is empty then return empty result as it means there is only one type of character in input
                    if (finalstring.Length!=0)
                    {
                        //check if the leftover can be fitted in front or end of the string
                        if (finalstring[0] != mapping.ElementAt(0).Key)
                        {
                            // finalstring = mapping.ElementAt(0).Key + finalstring;
                            finalstring.Insert(0, mapping.ElementAt(0).Key);
                            mapping[mapping.ElementAt(0).Key]--;
                            continue;
                        }
                        if (finalstring[finalstring.Length - 1] != mapping.ElementAt(0).Key)
                        {
                            finalstring.Append(mapping.ElementAt(0).Key);
                            mapping[mapping.ElementAt(0).Key]--;
                            continue;
                        }

                        //this for is not needed as there will be max one characters left at the end has to be adjusted 
                        //in first position.this loop is futile and will only be a  waste of time here
                        //if elements are still left try fitting them into places where they will not become adjacent
                        for (int i = 0; i < finalstring.Length - 1; i++)
                        {
                            if (finalstring[i]! != mapping.ElementAt(0).Key && finalstring[i+1]! != mapping.ElementAt(0).Key)
                            {
                                // finalstring = finalstring.Substring(0, i + 1) + mapping.ElementAt(0).Key + finalstring.Substring(i + 1);
                                finalstring.Insert(i + 1, mapping.ElementAt(0).Key);
                                //check if more elements are left if not break
                                if (mapping.ElementAt(0).Value == 0)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        //Console.WriteLine("no results");
                        return "";
                    }
                    //after all the processing if we still have elements left in dictionary we will return empty string as o/p because that means
                    //there is some character for which we cannot find the correct position.
                    if(mapping.ElementAt(0).Value!=0)
                    {
                        //Console.WriteLine("no results");
                        return "";
                    }
                }
            }
            return finalstring.ToString();
        }
    }
}
