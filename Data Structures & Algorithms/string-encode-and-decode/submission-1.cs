public class Solution
{

    public string Encode(IList<string> strs)
    {
        StringBuilder encodedList = new StringBuilder();
        foreach (var str in strs)
        {
            encodedList.Append(str.Length).Append('#').Append(str);
        }
        return encodedList.ToString();
    }

    public List<string> Decode(string s)
    {
        List<string> decodedList = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            int delimiterIndex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, delimiterIndex - i));
            string str = s.Substring(delimiterIndex + 1, length);
            decodedList.Add(str);
            i = delimiterIndex + 1 + length;
        }
        return decodedList;
    }
}
