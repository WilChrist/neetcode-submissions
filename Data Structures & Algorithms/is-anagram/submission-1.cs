public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> charCountS = BuildCharCount(s);
        Dictionary<char, int> charCountT = BuildCharCount(t);

        if (charCountS.Count != charCountT.Count)
        {
            return false;
        }

        foreach (var kvp in charCountS)
        {
            if (!charCountT.ContainsKey(kvp.Key) || charCountT[kvp.Key] != kvp.Value)
            {
                return false;
            }
        }

        return true;
    }

    private static Dictionary<char, int> BuildCharCount(string s)
    {
        Dictionary<char, int> charCountS = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (charCountS.ContainsKey(c))
            {
                charCountS[c]++;
            }
            else
            {
                charCountS[c] = 1;
            }
        }
        return charCountS;
    }
}
