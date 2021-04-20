using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/x-of-a-kind-in-a-deck-of-cards/
    /// </summary>
    class X_Of_a_Kind_In_Deck
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < deck.Length; i++)
            {
                if (!dict.ContainsKey(deck[i]))
                {
                    dict.Add(deck[i], 1);
                }
                else
                {
                    dict[deck[i]]++;
                }
            }
            //Quick check to see if the min value is less than 2 we can return false and not do the process 
            var keyAndValue = dict.OrderBy(kvp => kvp.Value).First().Value;
            if (keyAndValue < 2)
            {
                return false;
            }
            //From here on we have to take each element at a time and calculate gcd. 
            //we will use the result of gcd to calculate gcd of next value
            int result = dict[dict.ElementAt(0).Key];
            for (int i = 1; i < dict.Count; i++)
            {
                if (dict[dict.ElementAt(i).Key] < 2)
                {
                    return false;
                }
                else
                {
                    result = GCD(result, dict[dict.ElementAt(i).Key]);
                }
            }
            //once gcd is calculated check if gcd is less than 2 then we return false.
            if (result < 2)
            {
                return false;
            }
            return true;
        }
        private int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}
