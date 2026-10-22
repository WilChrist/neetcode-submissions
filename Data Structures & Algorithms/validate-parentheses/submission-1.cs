public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        HashSet<char> openSet = new HashSet<char> { '(', '{', '[' };
        foreach (char c in s)
        {
            if (openSet.Contains(c))
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0 || stack.Pop() != getOpp(c))
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }

    public char getOpp(char c)
    {
        return c switch
        {
            '(' => ')',
            '{' => '}',
            '[' => ']',
            ')' => '(',
            '}' => '{',
            ']' => '[',
            _ => throw new ArgumentException("Invalid character"),
        };
    }
}