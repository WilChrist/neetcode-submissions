public class Solution {
    public int MaxArea(int[] n) {
        int l = 0;
        int r = n.Length - 1;
        int res = 0;
        while (l < r) {
            int u = (r - l) * Math.Min(n[r], n[l]);
            if (u > res) {
                res = u;
            }
            if (n[r] < n[l]) {
                r--;
            } else {
                l++;
            }
        }
        return res;
    }
}
