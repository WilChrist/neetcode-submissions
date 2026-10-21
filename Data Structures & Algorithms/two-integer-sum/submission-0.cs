public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var res = new int[2];
        Dictionary<int, int> memo = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (memo.ContainsKey(complement))
            {
                res[0] = memo[complement];
                res[1] = i;
                return res;
            }
            memo[nums[i]] = i;
        }
        return res;
    }
}
