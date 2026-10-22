public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] result = new int[n];
        // Stack stores indices of days
        Stack<int> stack = new Stack<int>();

        for (int i = n - 1; i >= 0; i--)
        {
            // Pop indices with temperatures <= current temperature
            while (stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i])
            {
                stack.Pop();
            }

            // If stack is not empty, top element is the next warmer day
            result[i] = stack.Count == 0 ? 0 : stack.Peek() - i;

            // Push current index onto stack
            stack.Push(i);
        }

        return result;
    }
}