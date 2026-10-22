public class Solution
{
    public bool IsValid(string s)
    {
        if(s.Length % 2 != 0 || s.Length == 0)
        {
            return false;
        }

        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> openToCloseMap = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };
        foreach (char c in s)
        {
            if (openToCloseMap.ContainsKey(c))
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0 || stack.Pop() != openToCloseMap.FirstOrDefault(x => x.Value == c).Key)
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}