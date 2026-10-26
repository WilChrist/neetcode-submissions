public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++) {
            // Skip duplicate outer elements
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            
            // Optimization: If the smallest possible sum > 0, no more triplets can sum to 0
            if (nums[i] > 0) break;

            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r) {
                int sum = nums[i] + nums[l] + nums[r];

                if (sum == 0) {
                    res.Add(new List<int> { nums[i], nums[l], nums[r] });

                    // Skip duplicate inner elements
                    while (l < r && nums[l] == nums[l + 1]) l++;
                    while (l < r && nums[r] == nums[r - 1]) r--;

                    l++;
                    r--;
                } else if (sum < 0) {
                    l++;
                } else {
                    r--;
                }
            }
        }

        return res;
    }
}