using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMDemo
{
    class AmazonCustomerReviews
    {
        public static List<List<string>> searchSuggestions(List<string> repository, string customerQuery)
        {
            List<List<string>> results = new List<List<string>>();
            SortedSet<string> relevantRepo = new SortedSet<string>();
            int index = 0;
            int suggestionCompareLength = 2;
            //Initial step to parse and get relevant strings
            if (customerQuery.Length >= 2)
            {

                var querySubstring = customerQuery.Substring(index, suggestionCompareLength);
                foreach (var word in repository)
                {
                    if (querySubstring.Equals(word.Substring(index, suggestionCompareLength), StringComparison.OrdinalIgnoreCase))
                    {
                        relevantRepo.Add(word);
                    }
                }
            }
            results.Add(new List<string>(relevantRepo.Take(3)));
           
            suggestionCompareLength++;
            int comparedLength = 2;
            while (comparedLength <= customerQuery.Substring(index, customerQuery.Length - 2).Length)
            {
                //Get Subsequent Strings
                var querySubstring = customerQuery.Substring(index, suggestionCompareLength);
                int count = 0;
                var tempResult = new List<string>();
                foreach(var word in relevantRepo)
                {
                    if(word.Length>= suggestionCompareLength && word.Substring(index,suggestionCompareLength).Equals(querySubstring))
                    {
                        tempResult.Add(word);
                        count++;
                    }
                    if(count==3)
                    {
                        break;
                    }
                }
                comparedLength++;
                results.Add(tempResult);
                suggestionCompareLength++;
            }
            return results;
        }
    }
}
