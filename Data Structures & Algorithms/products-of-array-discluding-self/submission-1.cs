public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if (nums.Length < 2)
            return nums;

        int[] pref = new int[nums.Length];
        int[] suff = new int[nums.Length];
        pref[0] = 1;
        suff[nums.Length - 1] = 1;

        for (int i = 1, j = nums.Length - 2; i < nums.Length; i++, j--) {
            // Console.WriteLine(pref[i]);
            pref[i] = pref[i - 1] * nums[i - 1];
            suff[j] = suff[j + 1] * nums[j + 1];
        }

        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++) {
            res[i] = pref[i] * suff[i];
        }

        return res;
    }
}
