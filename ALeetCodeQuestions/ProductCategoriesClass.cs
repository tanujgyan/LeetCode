using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// https://leetcode.com/discuss/interview-question/690707/Amazon-or-Phone-Interview-or-Group-Product-Id-pairs-into-Categories
/// </summary>
namespace ALQ
{
    /// <summary>
    /// The idea behind this algorithm is to use DFS. On a pen and paper draw the graph first to help visualize the problem
    /// and based on the input I am taking for this ((1,2), (2,5), (3,4), (4,6), (6,8), (5,7), (5,2), (5,2)) the graph will look like
    /// 1-->2-->5-->7
    ///     ^  
    ///     |_ _| 
    ///     
    /// 3-->4-->6-->8
    /// 
    /// We can easily see the DFS here. Build an adjacency list and run the standard DFS code to get the values
    /// </summary>
    class ProductCategoriesClass
    {
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        public IList<IList<int>> CategorizeProducts(int[][] products)
        {
            BuildAdjacencyList(products);
            List<int> visited = new List<int>();
            List<IList<int>> productCategories = new List<IList<int>>();
            List<int> productCategory = new List<int>();
            foreach(var element in adjacencyList)
            {
                if(!visited.Contains(element.Key))
                {
                    CategorizeProductsHelper(element.Key, visited,productCategory);
                    //dump product category into product categories
                    productCategories.Add(productCategory);
                    productCategory = new List<int>();
                }
                
              
            }
            return productCategories;
        }
        private void CategorizeProductsHelper(int node, List<int> visited,List<int> productCategory)
        {
            if (visited.Contains(node))
            {
                return;
            }
            visited.Add(node);
            productCategory.Add(node);
            if (adjacencyList.ContainsKey(node))
            {
                foreach (var neghibor in adjacencyList[node])
                {
                    CategorizeProductsHelper(neghibor, visited, productCategory);
                }
            }
        }
        private void BuildAdjacencyList(int[][] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (!adjacencyList.ContainsKey(products[i][0]))
                {
                    adjacencyList.Add(products[i][0], new List<int>() { products[i][1] });
                }
                else
                {
                    adjacencyList[products[i][0]].Add(products[i][1]);
                }
            }
        }
    }
}
