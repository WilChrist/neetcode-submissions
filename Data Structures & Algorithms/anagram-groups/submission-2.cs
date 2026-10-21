public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> memo = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            int[] count = new int[26];
            foreach (char c in s) {
                count[c - 'a']++;
            }
            string key = string.Join(",", count);

            if (!memo.ContainsKey(key)) {
                memo[key] = new List<string>();
            }
            memo[key].Add(s);
        }

        return memo.Values.ToList<List<string>>();
    }
}
