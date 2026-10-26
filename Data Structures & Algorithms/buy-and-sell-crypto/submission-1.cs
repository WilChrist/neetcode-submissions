public class Solution
{
    public int MaxProfit(int[] p)
    {
        int l = 0;
        int r = 0;
        int res = 0;
        for (int i = 0; i < p.Length; i++)
        {
            int profit = p[r] - p[l];
            if (profit > res)
            {
                res = profit;
            }
            else
            {
                if(p[r] < p[l]) l = r;
            }
            r++;
        }
        return res;
    }
}
