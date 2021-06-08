using LeetCodeChallenge.June_2021;
using System;

namespace LeetCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumPerformanceOfATeamDriverCode();
        }

        private static void MaximumPerformanceOfATeamDriverCode()
        {
            MaximumPerformanceOfATeam maximumPerformanceOfATeam = new MaximumPerformanceOfATeam();
            maximumPerformanceOfATeam.MaxPerformance(6, new int[] { 2, 10, 3, 1, 5, 8 }, new int[] { 5, 4, 3, 9, 7, 2 }, 3);
        }
    }
}
