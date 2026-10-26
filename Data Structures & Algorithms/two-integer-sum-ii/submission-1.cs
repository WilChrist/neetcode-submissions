public class Solution {
    public int[] TwoSum(int[] n, int t) {
        int l = 0;
        int r = n.Length - 1;
        while (l < r) {
            int sum = n[l] + n[r];
            if (sum == t) {
                break;
            } else if (sum > t) {
                r--;
            } else {
                l++;
            }
        }
        return new int[] { l+1, r+1 };
    }
}
