public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 2) return s.Length;
        int l = 0, r = 0;
        int max = 0;
        HashSet<char> set = new HashSet<char>();

        while(r < s.Length)
        {
            if (!set.Contains(s[r]))
            {
                set.Add(s[r]);
                r++;
                max = Math.Max(max, r - l);
            }
            else
            {
                set.Remove(s[l]);
                l++;
            }
        }
        return max;
    }
}