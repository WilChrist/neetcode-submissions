public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        if (nums.Length < 2) return nums;

        int[] pref = new int[nums.Length];
        int[] suff = new int[nums.Length];
        pref[0] = nums[0];
        suff[nums.Length - 1] = nums[nums.Length - 1];

        for (int i = 1, j = nums.Length - 2; i < nums.Length; i++, j--)
        {

            //Console.WriteLine(pref[i]);
            pref[i] = pref[i - 1] * nums[i];
            suff[j] = suff[j + 1] * nums[j];
        }

        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                res[i] = suff[i + 1];
            }
            else if (i == nums.Length - 1)
            {
                res[i] = pref[i - 1];
            }
            else
            {
                res[i] = pref[i - 1] * suff[i + 1];
            }
        }

        return res;

    }
}
