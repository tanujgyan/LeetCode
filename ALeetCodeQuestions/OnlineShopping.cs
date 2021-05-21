using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALQ
{
    class OnlineShopping
    {
        int totalWays = 0;
        List<List<int>> combinationsF = new List<List<int>>();
        public int NumberOfWays(int[] priceOfJeans, int[] priceOfTops, int[] priceOfSkirts, int[] priceOfShoes, int dollars)
        {
            List<int[]> list = new List<int[]>();
            list.Add(priceOfJeans);
            list.Add(priceOfTops);
            list.Add(priceOfShoes);
            list.Add(priceOfSkirts);
            NumberOfWaysHelper(list, dollars, 0, new List<int>());
            return totalWays;

        }
        private void NumberOfWaysHelper(List<int[]> list,int dollars,int index,List<int> combinations)
        {
            if(index==4)
            {
                combinationsF.Add(new List<int>(combinations));
                if (combinations.Sum()<=dollars)
                {
                    totalWays++;
                    
                }

                combinations = new List<int>();
                return;
            }
            if(index>4)
            {
                return;
            }
            for(int i=0;i<list[index].Length;i++)
            {
                combinations.Add(list[index][i]);
                NumberOfWaysHelper(list, dollars, index + 1, combinations);
                combinations.RemoveAt(combinations.Count - 1);
            }
           
        }
    }
}
