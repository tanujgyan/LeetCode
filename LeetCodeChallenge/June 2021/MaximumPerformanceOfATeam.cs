using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenge.June_2021
{
    //This solution was attempted using DFS and is getting timeout 
    //class MaximumPerformanceOfATeam
    //{
    //    long maxPerformance = 0;
    //    const long mod = 1000000007;
    //    public int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
    //    {
    //        CreateCombinations(n, k, speed, efficiency);
    //        return (int)maxPerformance % (int)mod;
    //    }
    //    private List<List<int>> CreateCombinations(int n, int k,int[] speed,int[] efficiency)
    //    {
    //        List<List<int>> result = new List<List<int>>();
    //        List<int> item = new List<int>();
    //        // because it need to begin from 1
    //        CreateCombinationHelper(n, k, 1, item, speed,efficiency);
    //        return result;
    //    }
    //    private void CreateCombinationHelper(int n, int k, int start, List<int> item,int[] speed,int[] efficiency)
    //    {
    //        if(item.Count<k && item.Count>0)
    //        {
    //            CalculatePerformance(speed, efficiency, item);
    //        }
    //        if (item.Count == k)
    //        {
    //            CalculatePerformance(speed, efficiency, item);
    //            return;
    //        }

    //        for (int i = start; i <= n; i++)
    //        {
    //            item.Add(i);
    //            CreateCombinationHelper(n, k, i + 1, item,speed,efficiency);
    //            item.RemoveAt(item.Count - 1);
    //        }
    //    }
    //    private void CalculatePerformance(int[] speed, int[] efficiency,List<int> combinations)
    //    {
    //        long tempMaxPerformance = 0;
    //        long sum = 0;
    //        long min = long.MaxValue;
    //        for (int i = 0; i < combinations.Count; i++)
    //        {
    //            sum += speed[combinations[i] - 1];
    //            min = Math.Min(efficiency[combinations[i] - 1], min);
    //        }
    //        tempMaxPerformance = sum * min;
    //        maxPerformance = Math.Max(maxPerformance, tempMaxPerformance);
    //    }
    //}

    class MaximumPerformanceOfATeam
    {
        public int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
        {
            int counter = 0, mod = (int)(1e9) + 7;
            List<Person> list = new List<Person>();
            for (int i = 0; i < speed.Length; i++)
                list.Add(new Person(speed[i], efficiency[i]));

            // sort by efficiency
            list.Sort((x, y) => y.e - x.e);

            SortedSet<int> pq = new SortedSet<int>(Comparer<int>.Create(
                (x, y) =>
                {
                    int xSpeed = list[x].s, ySpeed = list[y].s;
                    return xSpeed != ySpeed ? xSpeed - ySpeed : y - x;
                }
            ));

            long maxPerformance = 0, currSpeed = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (pq.Count == k)
                {
                    // remove the person with the least speed
                    currSpeed -= list[pq.Min].s;
                    pq.Remove(pq.Min);
                }

                pq.Add(i);
                var person = list[i];
                currSpeed += person.s;

                long currPerformance = (currSpeed * person.e);
                maxPerformance = Math.Max(maxPerformance, currPerformance);
            }
            return (int)(maxPerformance % mod);
        }
    }
    public class Person
    {
        // speed, efficiency
        public int s;
        public int e;

        public Person(int s, int e)
        {
            this.s = s;
            this.e = e;
        }
    }
}
