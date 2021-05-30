using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //NextGreaterElementDriverCode();
            StockSpannerDriverCode();
        }

        private static void StockSpannerDriverCode()
        {
            StockSpanner stockSpanner = new StockSpanner();
            Console.WriteLine(stockSpanner.Next(100));
            Console.WriteLine(stockSpanner.Next(80));
            Console.WriteLine(stockSpanner.Next(60));
            Console.WriteLine(stockSpanner.Next(70));
            Console.WriteLine(stockSpanner.Next(60));
            Console.WriteLine(stockSpanner.Next(75));
            Console.WriteLine(stockSpanner.Next(85));
        }

        private static void NextGreaterElementDriverCode()
        {
            NextGreaterElement nextGreaterElement = new NextGreaterElement();
            nextGreaterElement.NextGreaterElementMethod(new int[] { 5,4,3,2,1 });
        }
    }
}
