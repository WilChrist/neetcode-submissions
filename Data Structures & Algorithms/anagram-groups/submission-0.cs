public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> memo = new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            string sortedKey = string.Concat(s.OrderBy(c => c));
            if (memo.ContainsKey(sortedKey))
            {
                memo[sortedKey].Add(s);
            }
            else
            {
                memo[sortedKey] = new List<string> { s };
            }
        }

        List<List<string>> res = new List<List<string>>();

        foreach (var kvp in memo)
        {
            res.Add(kvp.Value);
        }
        return res;
    }
}

