public class Solution {
    public List<List<int>> ThreeSum(int[] sn) {
        List<List<int>> res = new List<List<int>>();
        Array.Sort(sn);

        Dictionary<string, int> d = new Dictionary<string, int>();

        for (int i = 0; i < sn.Length - 2; i++) {
            int l = i + 1;
            int r = sn.Length - 1;

            while (l < r) {
                int sum = sn[l] + sn[r] + sn[i];
                
                if (sum == 0) {
                    string k = $"{sn[i]},{sn[l]},{sn[r]}";
                    if (!d.ContainsKey(k)) {
                        res.Add(new List<int>() { sn[i], sn[l], sn[r] });
                        d[k] = 1;
                    }
                    // Always move pointers to avoid infinite loop on duplicate keys
                    l++;
                    r--;
                } else if (sum > 0) {
                    r--;
                } else {
                    l++;
                }
            }
        }

        return res;
    }
}