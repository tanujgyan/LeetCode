using System;
using System.Collections.Generic;

namespace AMActual
{
    class Program
    {
        static void Main(string[] args)
        {
            //Result.connectedSum(10, new List<string>() { "1 2", "1 3", "2 4", "3 5", "7 8" });
            //Result.connectedSum(4, new List<string>() { "1 2", "1 4" });
            //Result.connectedSum(8, new List<string>() { "8 1", "5 8", "7 3","8 6" });
            Class2.countGroups(new List<string>() { "1000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000" });
        }
    }
}
