public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (memo.ContainsKey(nums[i]))
            {
                return true;
            }
            memo[nums[i]] = i;
        }
        return false;
    }
}