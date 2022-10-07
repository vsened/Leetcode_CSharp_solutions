using System;

namespace Algorithms_6
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int max = prices[0];
            int min = prices[0];
            int dif = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    max = prices[i];
                    min = prices[i];
                }
                else if (prices[i] > max)
                {
                    max = prices[i];
                }
                dif = dif > (max - min) ? dif : (max - min);
            }
            return dif;
        }
    }
}
