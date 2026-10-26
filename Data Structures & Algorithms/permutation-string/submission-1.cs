public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s2.Length < s1.Length) return false;
        int l = 0, r = s1.Length;
        while (l <= s2.Length - s1.Length)
        {
            int[] freqM = new int[26];
            foreach (char c in s1)
            {
                freqM[c - 'a']++;
            }

            for (int i = l; i < l + r; i++)
            {
                freqM[s2[i] - 'a']--;
            }

            if (!freqM.Any(c => c > 0))
            {
                return true;
            }
            l++;
        }
        return false;
    }
}