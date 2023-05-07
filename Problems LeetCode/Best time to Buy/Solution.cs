class Solution
{
    static void Main(string[] args)
    {
        int[] arr = { 7, 1, 5, 3, 6, 4 };
        Console.Write(MaxProfit(arr));
    }

    public static int MaxProfit(int[] prices)
    {
        // prices - array with prices of a product
        // prices[i] - the price of given stock on the i day

        // ex prices = [ 7, 1, 5, 3, 6, 4 ]
        // output = 5 ( Buy on day 2 with 1 and sell on day 5 with 6, profit = 6 - 1 = 5 )

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }

            int profit = prices[i] - minPrice;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }

        return maxProfit;
    }
}
