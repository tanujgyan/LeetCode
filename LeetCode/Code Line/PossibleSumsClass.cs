using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Code_Line
{
    class PossibleSumsClass
    {
        public int possibleSums(int[] coins, int[] quantity)
        {

            int coinsLength = coins.Length;

            HashSet<int> possibleSumsSet = new HashSet<int>();
            possibleSumsSet.Add(0);
            //take coins 1 by 1 
            for (int i = 0; i < coinsLength; i++)
            {
                //once we get a new coin we need to add it to every present value in subset 
                //we have to do .ToArray() as without it will not let us modify the collection while iterating over it
                foreach (var elem in possibleSumsSet.ToArray())
                {
                    //we add it to first element of subset
                    var e = elem + coins[i];
                    //then if the coin is repeating add it to itself and add then add it to possible sum set.
                    //we can use elem only once
                    //thats why we are defining a local variable doing changes to it and then adding to collection
                    for (int j = 0; j < quantity[i]; j++)
                    {
                        possibleSumsSet.Add(e);
                        e += coins[i];
                    }
                }
                
            }
            return possibleSumsSet.Count;
        }

    }
}

