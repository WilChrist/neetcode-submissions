public class Solution
{

    public string Encode(IList<string> strs)
    {
        List<string> encodedList = new List<string>();
        foreach (var str in strs)
        {
            encodedList.Add(str.Length + "#" + str);
        }
        return string.Join("", encodedList);
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
