using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
/// <summary>
/// A Company parses logs of online store user transactions/activity to flag fraudulent activity.

//The log file is represented as an Array of arrays. The arrays consist of the following data:

//[ <# of transactions>]

//For example:

//[345366 89921 45]

//Note: the data is space delimited

//So, the log data would look like:

//[
//[345366 89921 45],
//[029323 38239 23]
//...
//]
//Write a function to parse the log data to find distinct users that meet or cross a certain threshold.

//The function will take in 2 inputs:
//logData: Log data in form an array of arrays

//threshold: threshold as an integer

//Output:
//It should be an array of userids that are sorted.

//If same userid appears in the transaction as userid1 and userid2, it should count as one occurrence, not two.

//Example:
//Input:
//logData:

//[
//[345366 89921 45],
//[029323 38239 23],
//[38239 345366 15],
//[029323 38239 77],
//[345366 38239 23],
//[029323 345366 13],
//[38239 38239 23]
//...
//]
//threshold: 3

//Output:[345366 , 38239, 029323]
//Explanation:
//Given the following counts of userids, there are only 3 userids that meet or exceed the threshold of 3.

//345366 -4 , 38239 -5, 029323-3, 89921-1
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea is to use a dictionary to store the user ids and activity counts
    /// once the the activity count reaches threshold add it to result list
    /// At the end of loop sort the result using custom comparator
    /// </summary>
    class TransactionLogs
    {
        public List<string> TransactionLogsMethod(List<string> logData, int threshold)
        {
            LogsComparer comparer = new LogsComparer();
            List<string> result = new List<string>();
            Dictionary<string, int> userActivity = new Dictionary<string, int>();
            for(int i=0;i<logData.Count;i++)
            {
                var log = logData[i].Split(" ");
                int temp = 2;
                //if both userid1 and userid2 are same there is no point in processing them both
                if (log[0]==log[1])
                {
                    temp = 1;
                }
                for (int j = 0; j < temp; j++)
                {
                    if (!userActivity.ContainsKey(log[j]))
                    {
                        userActivity.Add(log[j], 1);
                    }
                    else
                    {
                        userActivity[log[j]]++;
                    }
                    //once it hits threshold we will add it, we are not checking for >= to avoid duplicates
                    //the idea is once it hits threshold any subsequent hits are no longer important
                    if (threshold == userActivity[log[j]])
                    {
                        result.Add(log[j]);
                    }
                }
            }
            result.Sort((b,a) => comparer.Compare(a, b));
            return result;
        }
        class LogsComparer : IComparer<string>
        {
            public int Compare([AllowNull] string x, [AllowNull] string y)
            {
                int.TryParse(x, out int ix);
                int.TryParse(y, out int iy);
                return ix - iy;
            }
        }
    }
}
